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
        private List<string> _propertiesInsideFile;
        private List<string> _propertiesUsedInsideCopy;
        private List<string> _differencies;
        public FileDataModel(string filePath)
        {
            FilePath = filePath;
        }
        public string FilePath {
            get
            {
                return _filePath;
            }
            set
            {
                _filePath = value;
            }
        }
        public List<string> PropertiesInsideFile {
            get
            {
                return _propertiesInsideFile;
            }
            set
            {
                _propertiesInsideFile = value;
            }
        }
        public List<string> PropertiesUsedInsideCopy {
            get
            {
                return _propertiesUsedInsideCopy;
            }
            set
            {
                _propertiesUsedInsideCopy = value;
            }
        }
        public List<string> Differencies {
            get
            {
                return _differencies;
            }
            set
            {
                _differencies = value;
            }
        }
        
    }
}
