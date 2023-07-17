namespace VakifIntershipTask.view
{
    partial class ErrorList
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
            this.dataGridViewErrors = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewErrors
            // 
            this.dataGridViewErrors.AllowUserToAddRows = false;
            this.dataGridViewErrors.AllowUserToDeleteRows = false;
            this.dataGridViewErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewErrors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewErrors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewErrors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewErrors.Location = new System.Drawing.Point(11, 125);
            this.dataGridViewErrors.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewErrors.Name = "dataGridViewErrors";
            this.dataGridViewErrors.ReadOnly = true;
            this.dataGridViewErrors.RowHeadersWidth = 82;
            this.dataGridViewErrors.RowTemplate.Height = 33;
            this.dataGridViewErrors.Size = new System.Drawing.Size(1877, 783);
            this.dataGridViewErrors.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1862, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Probably there was supposed to be a Copy() method in these files, but these files" +
    " were not found.";
            // 
            // ErrorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 919);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewErrors);
            this.Name = "ErrorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ErrorList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ErrorList_FormClosing);
            this.Load += new System.EventHandler(this.ErrorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewErrors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewErrors;
        private System.Windows.Forms.Label label1;
    }
}