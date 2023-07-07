﻿namespace VakifIntershipTask
{
    partial class DirectoryDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblPathDirectory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberOfDTOFiles = new System.Windows.Forms.Label();
            this.lblNumberOfMissingContentFiles = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory Path :";
            // 
            // lblPathDirectory
            // 
            this.lblPathDirectory.AutoSize = true;
            this.lblPathDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPathDirectory.Font = new System.Drawing.Font("Segoe UI", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathDirectory.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPathDirectory.Location = new System.Drawing.Point(260, 21);
            this.lblPathDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPathDirectory.Name = "lblPathDirectory";
            this.lblPathDirectory.Size = new System.Drawing.Size(697, 59);
            this.lblPathDirectory.TabIndex = 1;
            this.lblPathDirectory.Text = "C:/Users/example/example/example";
            this.lblPathDirectory.Click += new System.EventHandler(this.lblPathDirectory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(742, 59);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of DTO Files in this directory: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(630, 59);
            this.label3.TabIndex = 3;
            this.label3.Text = "DTO Files with missing Content :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 51);
            this.label4.TabIndex = 4;
            // 
            // lblNumberOfDTOFiles
            // 
            this.lblNumberOfDTOFiles.AutoSize = true;
            this.lblNumberOfDTOFiles.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDTOFiles.Location = new System.Drawing.Point(744, 97);
            this.lblNumberOfDTOFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfDTOFiles.Name = "lblNumberOfDTOFiles";
            this.lblNumberOfDTOFiles.Size = new System.Drawing.Size(48, 59);
            this.lblNumberOfDTOFiles.TabIndex = 5;
            this.lblNumberOfDTOFiles.Text = "0";
            this.lblNumberOfDTOFiles.Click += new System.EventHandler(this.lblNumberOfDTOFiles_Click);
            // 
            // lblNumberOfMissingContentFiles
            // 
            this.lblNumberOfMissingContentFiles.AutoSize = true;
            this.lblNumberOfMissingContentFiles.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfMissingContentFiles.Location = new System.Drawing.Point(639, 159);
            this.lblNumberOfMissingContentFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfMissingContentFiles.Name = "lblNumberOfMissingContentFiles";
            this.lblNumberOfMissingContentFiles.Size = new System.Drawing.Size(48, 59);
            this.lblNumberOfMissingContentFiles.TabIndex = 6;
            this.lblNumberOfMissingContentFiles.Text = "0";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 226);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(1132, 512);
            this.dataGridView.TabIndex = 7;
            // 
            // DirectoryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 772);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblNumberOfMissingContentFiles);
            this.Controls.Add(this.lblNumberOfDTOFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPathDirectory);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DirectoryDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DirectoryDetails_FormClosing);
            this.Load += new System.EventHandler(this.DirectoryDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPathDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumberOfDTOFiles;
        private System.Windows.Forms.Label lblNumberOfMissingContentFiles;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}