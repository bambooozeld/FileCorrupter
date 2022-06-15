namespace SecureFileCorrupter
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
            this.InfoTextTopLabel = new System.Windows.Forms.Label();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.CorruptFileButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EncryptFile = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // InfoTextTopLabel
            // 
            this.InfoTextTopLabel.AutoSize = true;
            this.InfoTextTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTextTopLabel.Location = new System.Drawing.Point(55, 9);
            this.InfoTextTopLabel.Name = "InfoTextTopLabel";
            this.InfoTextTopLabel.Size = new System.Drawing.Size(313, 16);
            this.InfoTextTopLabel.TabIndex = 0;
            this.InfoTextTopLabel.Text = "Corrupt sensitive and important Files savely!";
            this.InfoTextTopLabel.Click += new System.EventHandler(this.InfoTextTopLabel_Click);
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(58, 337);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(315, 42);
            this.SelectFileButton.TabIndex = 1;
            this.SelectFileButton.Text = "Select File";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // CorruptFileButton
            // 
            this.CorruptFileButton.Location = new System.Drawing.Point(58, 422);
            this.CorruptFileButton.Name = "CorruptFileButton";
            this.CorruptFileButton.Size = new System.Drawing.Size(158, 42);
            this.CorruptFileButton.TabIndex = 2;
            this.CorruptFileButton.Text = "Corrupt File";
            this.CorruptFileButton.UseVisualStyleBackColor = true;
            this.CorruptFileButton.Click += new System.EventHandler(this.CorruptFileButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(58, 507);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(315, 42);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EncryptFile
            // 
            this.EncryptFile.Location = new System.Drawing.Point(222, 422);
            this.EncryptFile.Name = "EncryptFile";
            this.EncryptFile.Size = new System.Drawing.Size(151, 42);
            this.EncryptFile.TabIndex = 4;
            this.EncryptFile.Text = "Encrypt FIle";
            this.EncryptFile.UseVisualStyleBackColor = true;
            this.EncryptFile.Click += new System.EventHandler(this.EncryptFile_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 33);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(432, 564);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.EncryptFile);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CorruptFileButton);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.InfoTextTopLabel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure File Corrupter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoTextTopLabel;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Button CorruptFileButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button EncryptFile;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

