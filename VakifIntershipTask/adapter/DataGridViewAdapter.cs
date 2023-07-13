using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VakifIntershipTask
{
    internal class DataGridViewAdapter
    {
        private List<FileDataModel> _fileDataListToAdapt;
        private List<AdaptedFileDataModel> _adaptedFileData;
        public DataGridViewAdapter(List<FileDataModel> fileDataListToAdapt) {
            _fileDataListToAdapt = fileDataListToAdapt;
            _adaptedFileData = new List<AdaptedFileDataModel>();
        }

        public List<AdaptedFileDataModel> Adapt()
        {
            for (int i = 0; i < _fileDataListToAdapt.Count; i++)
            {
                _adaptedFileData.Add(
                    new AdaptedFileDataModel(
                        substractNameFromPath(_fileDataListToAdapt[i].FilePath),
                        _fileDataListToAdapt[i].FilePath,
                        convertListToString(_fileDataListToAdapt[i].PropertiesInsideFile),
                        convertListToString(_fileDataListToAdapt[i].PropertiesUsedInsideCopy),
                        convertListToString(_fileDataListToAdapt[i].Differencies)
                    )
                );
            }
            return _adaptedFileData;
        }

        private string convertListToString(List<String> fileDataList)
        {
            return string.Join(",", fileDataList);
        }

        private string substractNameFromPath(string path)
        {
            return path.Split('\\').Last();
        }

    }
}
