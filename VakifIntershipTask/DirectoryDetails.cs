using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
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
            try
            {
                //load olayında ekrandaki compoenntların değerleri atanmalı
                lblPathDirectory.Text = _selectedPath;
                _files = Directory.GetFiles(_selectedPath, "DTO*.cs", searchOption: SearchOption.AllDirectories);
                TaskManager manager = new TaskManager(_files);
                _fileInfos = manager.CheckAllFiles();
                _fileInfosHasTheMissingContent = new List<FileDataModel>();
                lblNumberOfDTOFiles.Text = _files.Length.ToString();
                foreach(FileDataModel fileInfo in _fileInfos)
                {
                    if(fileInfo.Differencies.Count > 0)
                    {
                        _fileInfosHasTheMissingContent.Add(fileInfo);
                    }
                }
                lblNumberOfMissingContentFiles.Text = _fileInfosHasTheMissingContent.Count.ToString();
                DataGridViewAdapter adapter = new DataGridViewAdapter(_fileInfosHasTheMissingContent);
                dataGridView.DataSource = adapter.Adapt();
                dataGridView.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            _form1Instance.Show(); //Bu form kapatıldığında yeniden diğer formu aç
        }

        
        //hücreye tıklanınca hücre verisini göster
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell selectedCell = dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string cellValue = selectedCell.Value?.ToString();

                MessageBox.Show(cellValue);
            }
        
        }

    }
}
