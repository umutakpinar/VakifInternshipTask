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
        private string _existingProperties;
        //private string _usedProperties;
        private string _missingProperties;
        public AdaptedFileDataModel(
            string fileName, 
            string filePath, 
            string existingProperties,
            //string usedProperties, 
            string missingProperties)
        {
            FileName = fileName;
            FilePath = filePath;
            ExistingProperties = existingProperties;
            //UsedProperties = usedProperties;
            MissingProperties = missingProperties;
        }

        
        public string FileName {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
            }
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
        public string ExistingProperties {
            get
            {
                return _existingProperties;
            }
            set
            {
                _existingProperties = value;
            }
        }
        /*public string UsedProperties {
            get
            {
                return _usedProperties;
            }
            set
            {
                _usedProperties = value;
            }
        }*/
        public string MissingProperties {
            get
            {
                return _missingProperties;
            }
            set
            {
                _missingProperties = value;
            }
        }
    }
}
