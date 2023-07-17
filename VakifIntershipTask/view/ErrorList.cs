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
        private DataTable _errorTable;
        private DirectoryDetails _instanceOfDirectoryDetails;
        public ErrorList(DataTable errorTable, DirectoryDetails instance)
        {
            InitializeComponent();
            ErrorTable = errorTable;
            _instanceOfDirectoryDetails = instance;
            disableFormControls(_instanceOfDirectoryDetails); //ErrorList ekranı açıldığında bir önceki Detay sayfasını komple disable etmek yerine yalnızca içerisindeki butonları disable ediyorum. Bu sayede error sayfası ile directory details sayfası yan yana kıyaslanabilir. Sayfayı komple disable edersek form penceresindeki büyütme küçültme taşıma gibi işlemler de yapılamıyor
        }

        public DataTable ErrorTable {
            get
            {
                return _errorTable;
            }
            set 
            {
                _errorTable = value;       
            }
        }

        private void ErrorList_Load(object sender, EventArgs e)
        {
            dataGridViewErrors.DataSource = ErrorTable;
        }

        private void ErrorList_FormClosing(object sender, FormClosingEventArgs e)
        {
            enableFormControls(_instanceOfDirectoryDetails); //Aldığım directory details instancesi ile, errorList formu kapatılırken directory details'İ yeniden tıklanabilir yap
        }

        private void disableFormControls(Form instance)
        {

            foreach (Control control in instance.Controls)
            {
                if (control is Button)
                {
                    control.Enabled = false; //Sanırım bir formdaki tüm öğeler control nesnesi olarak geçiyor bunların içeriinde buton olanları disable hale geitiryorum
                }
            }
        }

        private void enableFormControls(Form instance)
        {
            foreach (Control control in instance.Controls)
            {
                if (control is Button)
                {
                    // Butonları devre dışı bırak
                    control.Enabled = true;
                }
            }
        }
    }
}
