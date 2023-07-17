using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VakifIntershipTask.view
{
    public partial class ErrorList : Form
    {
        private List<string> _errorList;
        public ErrorList(List<string> errorList)
        {
            InitializeComponent();
            _errorList = errorList;
        }

        private void ErrorList_Load(object sender, EventArgs e)
        {
            dataGridViewErrors.DataSource = _errorList;
        }
    }
}
