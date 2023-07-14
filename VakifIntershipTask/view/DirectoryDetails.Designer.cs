namespace VakifIntershipTask
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberOfDTOFiles = new System.Windows.Forms.Label();
            this.lblNumberOfMissingContentFiles = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnFileErrors = new System.Windows.Forms.Button();
            this.lblDToFilesExceptGFiles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Directory Path :";
            // 
            // lblPathDirectory
            // 
            this.lblPathDirectory.AutoSize = true;
            this.lblPathDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPathDirectory.Font = new System.Drawing.Font("Segoe UI Variable Display", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPathDirectory.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPathDirectory.Location = new System.Drawing.Point(344, 19);
            this.lblPathDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPathDirectory.Name = "lblPathDirectory";
            this.lblPathDirectory.Size = new System.Drawing.Size(530, 43);
            this.lblPathDirectory.TabIndex = 0;
            this.lblPathDirectory.Text = "C:/Users/example/example/example";
            this.lblPathDirectory.Click += new System.EventHandler(this.lblPathDirectory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(627, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "All DTO Files (includes .g.cs): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(627, 43);
            this.label5.TabIndex = 10;
            this.label5.Text = "DTO Files with missing Content :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 38);
            this.label4.TabIndex = 4;
            // 
            // lblNumberOfDTOFiles
            // 
            this.lblNumberOfDTOFiles.AutoSize = true;
            this.lblNumberOfDTOFiles.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDTOFiles.Location = new System.Drawing.Point(640, 71);
            this.lblNumberOfDTOFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfDTOFiles.Name = "lblNumberOfDTOFiles";
            this.lblNumberOfDTOFiles.Size = new System.Drawing.Size(38, 45);
            this.lblNumberOfDTOFiles.TabIndex = 7;
            this.lblNumberOfDTOFiles.Text = "0";
            // 
            // lblNumberOfMissingContentFiles
            // 
            this.lblNumberOfMissingContentFiles.AutoSize = true;
            this.lblNumberOfMissingContentFiles.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfMissingContentFiles.Location = new System.Drawing.Point(648, 159);
            this.lblNumberOfMissingContentFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfMissingContentFiles.Name = "lblNumberOfMissingContentFiles";
            this.lblNumberOfMissingContentFiles.Size = new System.Drawing.Size(38, 45);
            this.lblNumberOfMissingContentFiles.TabIndex = 11;
            this.lblNumberOfMissingContentFiles.Text = "0";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 226);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(1846, 764);
            this.dataGridView.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefresh.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1633, 46);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 137);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutput.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnOutput.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOutput.Location = new System.Drawing.Point(1760, 46);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(110, 137);
            this.btnOutput.TabIndex = 3;
            this.btnOutput.Text = "Create Output File";
            this.btnOutput.UseVisualStyleBackColor = false;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnFileErrors
            // 
            this.btnFileErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileErrors.BackColor = System.Drawing.Color.Salmon;
            this.btnFileErrors.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFileErrors.Location = new System.Drawing.Point(1500, 46);
            this.btnFileErrors.Name = "btnFileErrors";
            this.btnFileErrors.Size = new System.Drawing.Size(110, 137);
            this.btnFileErrors.TabIndex = 1;
            this.btnFileErrors.Text = "Errors";
            this.btnFileErrors.UseVisualStyleBackColor = false;
            this.btnFileErrors.Click += new System.EventHandler(this.btnFileErrors_Click);
            // 
            // lblDToFilesExceptGFiles
            // 
            this.lblDToFilesExceptGFiles.AutoSize = true;
            this.lblDToFilesExceptGFiles.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDToFilesExceptGFiles.Location = new System.Drawing.Point(533, 117);
            this.lblDToFilesExceptGFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDToFilesExceptGFiles.Name = "lblDToFilesExceptGFiles";
            this.lblDToFilesExceptGFiles.Size = new System.Drawing.Size(38, 45);
            this.lblDToFilesExceptGFiles.TabIndex = 9;
            this.lblDToFilesExceptGFiles.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(513, 43);
            this.label3.TabIndex = 8;
            this.label3.Text = "DTO files (except .g.cs) :";
            // 
            // DirectoryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.lblDToFilesExceptGFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFileErrors);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblNumberOfMissingContentFiles);
            this.Controls.Add(this.lblNumberOfDTOFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumberOfDTOFiles;
        private System.Windows.Forms.Label lblNumberOfMissingContentFiles;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnFileErrors;
        private System.Windows.Forms.Label lblDToFilesExceptGFiles;
        private System.Windows.Forms.Label label3;
    }
}