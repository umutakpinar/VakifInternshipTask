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
        private DataGridView _dataGrid;
        private List<AdaptedFileDataModel> adaptedFileData;
        public DataGridViewAdapter(List<FileDataModel> fileDataListToAdapt, DataGridView dataGrid) {
            _fileDataListToAdapt = fileDataListToAdapt;
            _dataGrid = dataGrid;
            adaptedFileData = new List<AdaptedFileDataModel>();
        }

        public List<AdaptedFileDataModel> Adapt()
        {
            return adaptedFileData;
            //_dataGrid.DataSource dataSource2u burada eşitlemek yerine burada bir List<AdaptedFildeDataModel> dönmesi daha iyi olaiblir
        }

    }
}
