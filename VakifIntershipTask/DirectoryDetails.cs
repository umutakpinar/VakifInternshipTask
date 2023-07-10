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
            TaskManager.LoadData(lblPathDirectory, _selectedPath, _files, _fileInfos, _fileInfosHasTheMissingContent, lblNumberOfDTOFiles, lblNumberOfMissingContentFiles, dataGridView);
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
        //eğer path o an bir başkası tarafından değiştirillirse dataGridView'i yenilesin
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            TaskManager.LoadData(lblPathDirectory, _selectedPath, _files, _fileInfos, _fileInfosHasTheMissingContent, lblNumberOfDTOFiles, lblNumberOfMissingContentFiles, dataGridView);
            dataGridView.Update();
            dataGridView.Refresh();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblNumberOfMissingContentFiles.Text) != 0)
            {
                List<string> headers = new List<string>();
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                int indexOfLastSlash = _selectedPath.LastIndexOf("/");
                //string saveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); ; //Belki burada varsayılan olarak desktop seçili hale getirilebilir.
                saveFileDialog.FileName = _selectedPath.Substring(indexOfLastSlash+1) + "_analysis";
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    //string filePath = Path.GetDirectoryName(fileName);
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        foreach (DataGridViewColumn column in dataGridView.Columns)
                        {
                            headers.Add(column.HeaderText);
                        }
                        writer.WriteLine(DateTime.Now);
                        writer.WriteLine("Directory Path : {0}", _selectedPath);
                        writer.WriteLine("Number of DTO Files With Missing Content : {0}",lblNumberOfMissingContentFiles.Text);
                        writer.Write("\n*****************************************");
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            writer.Write("\n");
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                writer.Write("{0} : ", headers[cell.ColumnIndex]);
                                writer.Write(cell.Value.ToString());
                                writer.Write("\n");
                            }
                            writer.Write("\n");
                            writer.Write("*****************************************");
                        }
                    }
                    MessageBox.Show("Output file created!");
                }
            }
            else
            {
                MessageBox.Show("Everything looks fine for this directory. Nothing to dump.");
            }
        }
    }
}
