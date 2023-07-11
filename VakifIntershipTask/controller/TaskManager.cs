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
            
            List<string> privateFieldNames = FindPrivateFieldNames(fileContent);
            List<string> usedFieldsInsideCopy = FindUsedFieldsInsideCopy(fileContent);
            List<string> missedFieldsInsideCopy = CompareListsAndReturnDifferences(privateFieldNames, usedFieldsInsideCopy);
            
            currentFile.FieldNamesInsidePath = privateFieldNames;
            currentFile.PropertiesUsedInsideCopy = usedFieldsInsideCopy;
            currentFile.Differencies = missedFieldsInsideCopy;
           
            return currentFile;
        }

        //Bir DTO.cs içerisindeki private field'ları alır, ilk harflerini büyütür ve bir List<string olarak geri döndürür.>
        private List<string> FindPrivateFieldNames(string fileContent)
        {
            string pattern = @"(?<=_)(?<fields>.*)(?=;)";
            List<string> privateLabeledLines = FindPrivateLabeledLines(fileContent);
            List<string> privateFields = new List<string>();
            
            foreach(string line in privateLabeledLines)
            {
                Match match = Regex.Match(line, pattern);
                if(match.Success) {
                    char firstChar = char.ToUpper(match.Value[0]);
                    string result = match.Value;
                    result = firstChar + result.Substring(1);
                    privateFields.Add(result);
                }
            }

            return privateFields;
        }
        private List<string> FindPrivateLabeledLines(string fileContent)
        {
            string pattern = @"(?<=private)(?<privateRows>.*)";
            List<string> privateLabeledLines = new List<string>();
            using (StringReader reader = new StringReader(fileContent))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Regex.IsMatch(line, pattern))
                    {
                        privateLabeledLines.Add(line);
                    }
                }
            }

            return privateLabeledLines;
        }

        //Bir DTO.cs içerisindeki Copy metodunda kullanılan fieldları alır bir List<string olarak geri döndürür.>
        private List<string> FindUsedFieldsInsideCopy(string fileContent)
        {
            string pattern = @"(?<=this\.)(?<propertyUsedInsideCopy>.*)(?=;)";
            List<string> usedFieldsInsideCopy = new List<string>();
            using (StringReader reader = new StringReader(fileContent))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Match match = Regex.Match(line, pattern);
                    if (match.Success)
                    {
                        usedFieldsInsideCopy.Add(match.Value);
                    }
                }
            }

            return usedFieldsInsideCopy;
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
    }
}
