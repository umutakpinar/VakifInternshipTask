using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VakifIntershipTask
{
    internal class AdaptedFileDataModel
    {
        private string _fileName;
        private string _filePath;
        private string _existingFields;
        private string _usedProperties;
        private string _missingProperties;
        public AdaptedFileDataModel(string fileName,string filePath, string existingFields, string usedProperties, string missingProperties)
        {
           FileName = fileName;
           FilePath = filePath;
           ExistingFields = existingFields;
           UsedProperties = usedProperties;
           MissingProperties = missingProperties;
        }

        public string FileName { get => _fileName; set => _fileName = value; }
        public string FilePath { get => _filePath; set => _filePath = value; }
        public string ExistingFields { get => _existingFields; set => _existingFields = value; }
        public string UsedProperties { get => _usedProperties; set => _usedProperties = value; }
        public string MissingProperties { get => _missingProperties; set => _missingProperties = value; }
    }
}
