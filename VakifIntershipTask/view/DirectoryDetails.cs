using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VakifIntershipTask
{
    public partial class DirectoryDetails : Form
    {
        private Form1 _form1Instance;
        private string _selectedPath;
        private string[] _files;
        private List<FileDataModel> _fileInfos;
        private List<FileDataModel> _fileInfosHasTheMissingContent;
        public DirectoryDetails(Form1 form1Instance, string selectedPath)
        {
            InitializeComponent();
            _form1Instance = form1Instance;
            _selectedPath = selectedPath;
            _form1Instance.Hide(); //Form1'i gizle tekrar ekran açılmasın
        }

        private void DirectoryDetails_Load(object sender, EventArgs e)
        {
            TaskManager.LoadData(
                lblPathDirectory, 
                _selectedPath, _files,
                _fileInfos,
                _fileInfosHasTheMissingContent,
                lblNumberOfDTOFiles,
                lblNumberOfMissingContentFiles,
                dataGridView,
                lblDToFilesExceptGFiles,
                btnFileErrors
                );
        }

        private void lblPathDirectory_Click(object sender, EventArgs e)
        {
            //Buraya tıklanıldığında o klasör yolunu açmalı
            try
            {
                Process.Start("explorer.exe", "/open, " + _selectedPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DirectoryDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            _form1Instance.Show(); //Bu form kapatıldığında seçim formunu aç
        }
        
        //eğer path o an bir başkası tarafından değiştirillirse dataGridView'i yenilesin
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TaskManager.LoadData(lblPathDirectory, _selectedPath, _files, _fileInfos, _fileInfosHasTheMissingContent, lblNumberOfDTOFiles, lblNumberOfMissingContentFiles, dataGridView, lblDToFilesExceptGFiles, btnFileErrors);
            dataGridView.Update();
            dataGridView.Refresh();
        }
        
        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblNumberOfMissingContentFiles.Text) != 0)
            {
                TaskManager.OutputWriter(_selectedPath, dataGridView, lblNumberOfMissingContentFiles);
            }
            else
            {
                MessageBox.Show("Everything looks fine for this directory. Nothing to dump.");
            }
        }

        private void btnFileErrors_Click(object sender, EventArgs e)
        {
            TaskManager.showFileErrors();
        }
    }
}
