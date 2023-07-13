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
        public TaskManager(string[] dtoFilePaths) {
            _dtoFilePaths = dtoFilePaths;
        }

        public List<FileDataModel> CheckAllFiles()
        {
            List<FileDataModel> fileInfos = new List<FileDataModel>();
            foreach(string filePath in _dtoFilePaths) { 
                string fileContent = File.ReadAllText(filePath);
                fileInfos.Add(CheckFile(filePath, fileContent));
            }
            return fileInfos;
        }

        public FileDataModel CheckFile(string filePath,string fileContent)
        {
            FileDataModel currentFile = new FileDataModel(filePath);
            
            List<string> propertiesInsideFile = FindPropertiesInsideFile(fileContent);
            List<string> usedPropertiesInsideCopy = FindUsedPropertiesInsideCopy(fileContent);
            List<string> missedProperiesInsideCopy = CompareListsAndReturnDifferences(propertiesInsideFile, usedPropertiesInsideCopy);
            
            currentFile.PropertiesInsideFile = propertiesInsideFile; //Bu kısımda FieldNamesInsidePath kısmı değiştirilecek
            currentFile.PropertiesUsedInsideCopy = usedPropertiesInsideCopy;
            currentFile.Differencies = missedProperiesInsideCopy;
           
            return currentFile;
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
        private static List<string> CompareListsAndReturnDifferences(List<string> privateFields, List<string> usedInsideCopy)
        {
           List<string> missingFields = privateFields.Except(usedInsideCopy).ToList();
            return missingFields;
        }

        public static void LoadData(Label lblPathDirectory, string _selectedPath, string[] _files, List<FileDataModel> _fileInfos, List<FileDataModel> _fileInfosHasTheMissingContent, Label lblNumberOfDTOFiles, Label lblNumberOfMissingContentFiles,DataGridView dataGridView)
        {
            try
            {
                //load olayında ekrandaki compoenntların değerleri atanmalı
                lblPathDirectory.Text = _selectedPath;
                _files = Directory.GetFiles(_selectedPath, "DTO*.cs", searchOption: SearchOption.AllDirectories);
                TaskManager manager = new TaskManager(_files);
                _fileInfos = manager.CheckAllFiles();
                _fileInfosHasTheMissingContent = new List<FileDataModel>();
                lblNumberOfDTOFiles.Text = _files.Length.ToString();
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
    
        public static void OutputWriter(string _selectedPath, DataGridView dataGridView, Label lblNumberOfMissingContentFiles)
        {
            List<string> headers = new List<string>();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            int indexOfLastSlash = _selectedPath.LastIndexOf("/");
            //string saveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); ; //Belki burada varsayılan olarak desktop seçili hale getirilebilir.
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
    }
}
