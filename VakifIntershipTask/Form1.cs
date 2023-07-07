using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VakifIntershipTask
{
    public partial class Form1 : Form
    {
        string selectedPath;
        public Form1()
        {
            InitializeComponent();
            selectedPath = null;
        }
        
        private void btnSelectDirectoryPath_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();
                    if(result == DialogResult.OK) {
                        if (!string.IsNullOrEmpty(fbd.SelectedPath))
                        {
                            selectedPath = fbd.SelectedPath;
                            tbxDirectoryPath.Text = selectedPath;
                            DirectoryDetails directoryDetails = new DirectoryDetails(this, selectedPath);
                            directoryDetails.Show();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı path!");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
