using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace VakifIntershipTask
{
    internal class TaskManager
    {
        private string[] _dtoFilePaths;
        private static int _sumOfDTOFiles; //Artık .g.cs ve .cs dosyalarından ismi aynı olanları tek bir dosya gibi sayıyorum ve ekranda bunu göstereceğim. 
        private static List<String> _fileErrorList; //Olmaz ama olur da eğer seçilen dosyada Copy methodu yoksa ve .g.cs dosyası yoksa
        public static List<string> FileErrorList
        {
            get
            {
                return _fileErrorList;
            }
            set
            {
                _fileErrorList = value;
            }
        }

        public static int SumOfDTOFiles
        {
            get
            {
                return _sumOfDTOFiles;
            }
            set
            {
                _sumOfDTOFiles = value;
            }
        }

        public TaskManager(string[] dtoFilePaths) {
            _dtoFilePaths = dtoFilePaths;
            FileErrorList = new List<String>();
            SumOfDTOFiles = 0;
        }

        public List<FileDataModel> CheckAllFiles() //Yani aslında burada .g.cs olanları da çekiyoruz burada return edilen fileInfos listesi hem ismi DTo ile başlayıp .cs ile biten dosyaların sayısını veriyor yani.
        {
            List<FileDataModel> fileInfos = new List<FileDataModel>();
            foreach(string filePath in _dtoFilePaths) { 
                //string fileContent = File.ReadAllText(filePath);
                FileDataModel checkedFile = CheckFile(filePath);
                if(checkedFile != null)
                {
                    fileInfos.Add(checkedFile);
                }
            }

            return fileInfos;
        }

        public FileDataModel CheckFile(string filePath) //Burada bana gelen filePathler içerisinde hem .g.cs olanlar hem de .cs olanlar var bu nedenle ikisini ayırt etmeliyim.
        {
            FileDataModel currentFile; //yani burada direkt olarak bu filePath'i vermeden önce Copy var mı diye kontrol edecek. Copy var ise okey, Copy yok ise .g.cs olanı bulup onun filePAth'İni verecek

            try //buraya try catch eklemek zorunda kaldım çünkü olur da bir .cs dosyası içerisinde hem Copy yok hem de bu dosyanın .g.cs dosyası da yok ise FileNotFoundException atıyor. Böyle bir durum olmaz ama olursa diye bunları FileErrorList içerisinde tutuyorum
            {
                string fileContent = File.ReadAllText(filePath);
                string gfileContent;

                List<string> propertiesInsideFile;
                List<string> usedPropertiesInsideCopy;
                List<string> missedPropertiesInsideCopy;

                if (isNotGFile(filePath)) //sadece normal dosyaysa işlem yap .g dosyası olanlarla işlem ypmayız onları bu karar bloğunun içerisinde kontrol edeceğim
                {
                    SumOfDTOFiles++; //Eğer .g.cs dosyası değilse bunların sayısını öğrenmek için bir 
                    if (isCurrentFileHasCopy(fileContent)) //Copy var ise .g.'yi control etmeye gerek yok, demek ki bu normal .cs dosyası ve .g. dosyası yok çünkü Copy'e sahip //Ancak olur da normal .cs dosyası olmasıına rağmen Copy'si yoksa ve .g.cs dosyası da yoksa hata catch'e yakalatıyorum
                    {
                        currentFile = new FileDataModel(filePath);
                        propertiesInsideFile = FindPropertiesInsideFile(fileContent);
                        usedPropertiesInsideCopy = FindUsedPropertiesInsideCopy(fileContent);
                        missedPropertiesInsideCopy = CompareListsAndReturnDifferences(propertiesInsideFile, usedPropertiesInsideCopy);
                    }
                    else //Demek ki bu dosyanın bir de .g.cs olan versiyonu var. .g.'deki propertyler ile diğer propertyleri bir listede topla, .g. içerisindeki Copy()deki propertyleri de bir listede topla
                    {
                        string gfilePath = filePath.Replace(".cs", ".g.cs"); //windows dosya sistemi büyük küçük harfe duyarsızmış yani A.txt ile a.txt aynı dosyayı işaret ediyor denedim

                        currentFile = new FileDataModel(gfilePath); //ARTIK BURADA .g'nin pathini vermelisin!

                        gfileContent = File.ReadAllText(gfilePath);

                        propertiesInsideFile = FindPropertiesInsideFile(fileContent);
                        List<string> propertiesInsideGFile = FindPropertiesInsideFile(gfileContent);
                        propertiesInsideFile.AddRange(propertiesInsideGFile); //.cs ve .g.cs içerisindeki porpertyleri toplayıp propertiesInsideFile içine at
                        usedPropertiesInsideCopy = FindUsedPropertiesInsideCopy(gfileContent);
                        missedPropertiesInsideCopy = CompareListsAndReturnDifferences(propertiesInsideFile, usedPropertiesInsideCopy);
                    }

                    currentFile.PropertiesInsideFile = propertiesInsideFile; //Bu kısımda FieldNamesInsidePath kısmı değiştirilecek
                    currentFile.PropertiesUsedInsideCopy = usedPropertiesInsideCopy;
                    currentFile.Differencies = missedPropertiesInsideCopy;
                }
                else
                {
                    currentFile = null;
                }
            }
            catch (FileNotFoundException e)
            {
                recordNewFileError(e);
                return null;
            }

            return currentFile;
        }

        private void recordNewFileError(FileNotFoundException error)
        {
            FileErrorList.Add(error.Message);
        }

        bool isCurrentFileHasCopy(string fileContent)
        {
            return Regex.IsMatch(fileContent, @"(C|c)opy\(\)"); //Metotlar büyük harfle yazılır ama belki yanlışlıkla küçük harf ile yazılmıştır.
        }

        bool isNotGFile(string filePath) //.g.cs dosyası değilse true döndür
        {
            string pattern = @".*(?=((?<!\.g)\.cs))\.cs"; //.g. veya .G. şeklinde de yazılmış olabilir ama windows dosya sistemi büyük küçük harfe duyarsız
            return Regex.IsMatch(filePath, pattern);
        }

        //Bir DTO.cs içerisindeki private field'ları alır, bir List<string olarak geri döndürür.> 
        private List<string> FindPropertiesInsideFile(string fileContent)
        {
            List<string> usedPropertiesInsideFile = new List<string>();

            string pattern = @"(?<=DataMember.*\n.*public .* )(?<alanlar>\S+)";
            MatchCollection matches = Regex.Matches(fileContent, pattern);
            foreach (Match g in matches)
            {
                usedPropertiesInsideFile.Add(g.Groups["alanlar"].Value.Trim());
            }

            return usedPropertiesInsideFile;
        }

        //Bir DTO.cs içerisindeki Copy metodunda kullanılan propertyleri alır bir List<string olarak geri döndürür.>
        private List<string> FindUsedPropertiesInsideCopy(string fileContent)
        {
            List<string> usedPropertiesInsideCopy = new List<string>();

            string pattern = @"(?<=this\.)(?<propertyUsedInsideCopy>.*)(?=;)";
            MatchCollection matches = Regex.Matches(fileContent, pattern);
            foreach(Match g in matches)
            {
                usedPropertiesInsideCopy.Add(g.Groups["propertyUsedInsideCopy"].Value.Trim());
            }
            return usedPropertiesInsideCopy;
        }
        
        //İki listedeki farkları karşılaştırır. Farklı olan elemanları bir liste halinde geri döndürür, eğer ikisi de eşitse boş bir liste döndürür
        private static List<string> CompareListsAndReturnDifferences(List<string> existingProperties, List<string> usedInsideCopy)
        {
           List<string> missingFields = existingProperties.Except(usedInsideCopy).ToList();
            return missingFields;
        }

        public static void LoadData(
            Label lblPathDirectory, 
            string _selectedPath, string[] _files, 
            List<FileDataModel> _fileInfos, 
            List<FileDataModel> _fileInfosHasTheMissingContent, 
            Label lblNumberOfDTOFiles, 
            Label lblNumberOfMissingContentFiles,DataGridView dataGridView,
            Label lblDToFilesExceptGFiles,
            Button btnFileErrors)
        {
            try
            {
                //load olayında ekrandaki compoenntların değerleri atanmalı
                lblPathDirectory.Text = _selectedPath;
                _files = Directory.GetFiles(_selectedPath, "DTO*.cs", searchOption: SearchOption.AllDirectories);
                TaskManager manager = new TaskManager(_files);
                _fileInfos = manager.CheckAllFiles();
                _fileInfosHasTheMissingContent = new List<FileDataModel>();
                lblNumberOfDTOFiles.Text = _files.Length.ToString();  //Burada toplam .cs dosya sayısını göster hem DTO.cs hem de DTO.g.cs
                lblDToFilesExceptGFiles.Text = SumOfDTOFiles.ToString(); //Artık burada tüm DTO.cs - .g.cs gösteriliyor yani ismi aynı olan .g.cs ve .cs dosyaları tek bir DTO olarak sayılacak
                btnFileErrors.Text = "Errors\n" + FileErrorList.Count.ToString();
                foreach (FileDataModel fileInfo in _fileInfos)
                {
                    if (fileInfo.Differencies.Count > 0)
                    {
                        _fileInfosHasTheMissingContent.Add(fileInfo);
                    }
                }
                lblNumberOfMissingContentFiles.Text = _fileInfosHasTheMissingContent.Count.ToString();
                DataGridViewAdapter adapter = new DataGridViewAdapter(_fileInfosHasTheMissingContent);
                dataGridView.DataSource = adapter.Adapt();
                dataGridView.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        public static void OutputWriter(
            string _selectedPath, 
            DataGridView dataGridView,
            Label lblNumberOfMissingContentFiles)
        {
            List<string> headers = new List<string>();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            int indexOfLastSlash = _selectedPath.LastIndexOf("/");
            saveFileDialog.FileName = _selectedPath.Substring(indexOfLastSlash + 1) + "_analysis";
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                //string filePath = Path.GetDirectoryName(fileName);
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        headers.Add(column.HeaderText);
                    }
                    writer.WriteLine(DateTime.Now);
                    writer.WriteLine("Directory Path : {0}", _selectedPath);
                    writer.WriteLine("Number of DTO Files With Missing Content : {0}", lblNumberOfMissingContentFiles.Text);
                    writer.Write("\n*****************************************");
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        writer.Write("\n");
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            writer.Write("{0} : ", headers[cell.ColumnIndex]);
                            writer.Write(cell.Value.ToString());
                            writer.Write("\n");
                        }
                        writer.Write("\n");
                        writer.Write("*****************************************");
                    }
                }
                MessageBox.Show("Output file created!");
            }
        }

        public static void showFileErrors()
        {
            if(FileErrorList.Count > 0)
            {
                MessageBox.Show(string.Join("\n", FileErrorList));
            }
            else
            {
                MessageBox.Show("All .cs files or their .g.cs files are includes Copy() method.\nThis button made for to show: if someone forgets to write Copy method inside .cs file and if this .cs file does not have a .g.cs file, this file error will show here.");
            }
        }
    }
}
