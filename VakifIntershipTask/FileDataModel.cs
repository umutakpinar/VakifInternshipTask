using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VakifIntershipTask
{
    internal class FileDataModel
    {
        private string _filePath;
        private List<string> _fieldNamesInsidePath;
        private List<string> _propertiesUsedInsideCopy;
        private List<string> _differencies;
        public FileDataModel(string filePath)
        {
            FilePath = filePath;
        }

        public string FilePath { get => _filePath; set => _filePath = value; }
        public List<string> FieldNamesInsidePath { get => _fieldNamesInsidePath; set => _fieldNamesInsidePath = value; }
        public List<string> PropertiesUsedInsideCopy { get => _propertiesUsedInsideCopy; set => _propertiesUsedInsideCopy = value; }
        public List<string> Differencies { get => _differencies; set => _differencies = value; }
    }
}
