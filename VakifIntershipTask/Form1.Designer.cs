namespace VakifIntershipTask
{
    partial class Form1
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
            this.btnSelectDirectoryPath = new System.Windows.Forms.Button();
            this.lblDirectoryPath = new System.Windows.Forms.Label();
            this.tbxDirectoryPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectDirectoryPath
            // 
            this.btnSelectDirectoryPath.Location = new System.Drawing.Point(997, 140);
            this.btnSelectDirectoryPath.Name = "btnSelectDirectoryPath";
            this.btnSelectDirectoryPath.Size = new System.Drawing.Size(203, 162);
            this.btnSelectDirectoryPath.TabIndex = 0;
            this.btnSelectDirectoryPath.Text = "Select Directory";
            this.btnSelectDirectoryPath.UseVisualStyleBackColor = true;
            this.btnSelectDirectoryPath.Click += new System.EventHandler(this.btnSelectDirectoryPath_Click);
            // 
            // lblDirectoryPath
            // 
            this.lblDirectoryPath.AutoSize = true;
            this.lblDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectoryPath.Location = new System.Drawing.Point(41, 140);
            this.lblDirectoryPath.Name = "lblDirectoryPath";
            this.lblDirectoryPath.Size = new System.Drawing.Size(295, 31);
            this.lblDirectoryPath.TabIndex = 1;
            this.lblDirectoryPath.Text = "Search Directory Path :";
            // 
            // tbxDirectoryPath
            // 
            this.tbxDirectoryPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDirectoryPath.Location = new System.Drawing.Point(47, 200);
            this.tbxDirectoryPath.Name = "tbxDirectoryPath";
            this.tbxDirectoryPath.ReadOnly = true;
            this.tbxDirectoryPath.Size = new System.Drawing.Size(896, 38);
            this.tbxDirectoryPath.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 403);
            this.Controls.Add(this.tbxDirectoryPath);
            this.Controls.Add(this.lblDirectoryPath);
            this.Controls.Add(this.btnSelectDirectoryPath);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DTOAnalyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectDirectoryPath;
        private System.Windows.Forms.Label lblDirectoryPath;
        private System.Windows.Forms.TextBox tbxDirectoryPath;
    }
}

