namespace batch_convert_excel
{
    partial class convert_form
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
            this.filePath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.process = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Folder Directory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(16, 40);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(75, 23);
            this.filePath.TabIndex = 1;
            this.filePath.Text = "Browse";
            this.filePath.UseVisualStyleBackColor = true;
            this.filePath.Click += new System.EventHandler(this.getFilePath);
            // 
            // process
            // 
            this.process.Location = new System.Drawing.Point(16, 113);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(75, 23);
            this.process.TabIndex = 2;
            this.process.Text = "Process";
            this.process.UseVisualStyleBackColor = true;
            this.process.Click += new System.EventHandler(this.processForm);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Files Converted!";
            // 
            // convert_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.process);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.label1);
            this.Name = "convert_form";
            this.Text = "Batch Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.Label label2;
    }
}

