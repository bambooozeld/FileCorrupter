using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace SecureFileCorrupter
{
    public partial class Form1 : Form
    {
        string filepath_name = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void InfoTextTopLabel_Click(object sender, EventArgs e)
        {

        }
        public void SelectFileButton_Click(object sender, EventArgs e)
        {
            GetFPNasString();
        }
        public string GetFPNasString()
        {
            OpenFileDialog file = new OpenFileDialog();
            string NoFileSelected = "No File Selected!";

            if (file.ShowDialog() == DialogResult.OK)
            {
                filepath_name = file.FileName;
                SelectFileButton.Text = filepath_name;
                return filepath_name;
            }
            else
            {
                SelectFileButton.Text = NoFileSelected;
                return null;
            }
        }

        public void CorruptFileButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to corrupt this file?", "Corrupt Files", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (SelectFileButton.Text != "No File Selected!")
                {
                    byte[] fileBytes = File.ReadAllBytes(filepath_name);
                    StringBuilder sb = new StringBuilder();

                    foreach (byte b in fileBytes)
                    {
                        sb.Append(Convert.ToString(b, 2).PadLeft(0, '0'));
                    }
                    File.WriteAllText(filepath_name, sb.ToString());
                    string changedName = Path.ChangeExtension(filepath_name, null);
                    File.Move(filepath_name, changedName);
                    DialogResult answer = MessageBox.Show("Do you also want to encrypt this file?", "Encrypt Files", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        AES_Algo();
                    }
                    else if (answer == DialogResult.No)
                    {

                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void EncryptFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to encrypt this file?", "Encrypt Files", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (SelectFileButton.Text != "No File Selected!")
                {
                    AES_Algo();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
        public void AES_Algo()
        {

            try
            {
                using (FileStream fileStream = new FileStream(filepath_name, FileMode.OpenOrCreate))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                        aes.Key = key;

                        byte[] iv = aes.IV;
                        fileStream.Write(iv, 0, iv.Length);

                        using (CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (StreamWriter encryptWriter = new StreamWriter(cryptoStream))
                            {
                                encryptWriter.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890");
                            }
                        }
                    }
                }

                MessageBox.Show("Files Encrypted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed: {0}",ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit this program? \n" + "Have you saved everything?"
            , "Exit Program", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bambooozeld/FileCorrupter");
        }
        
        private void Images(string[] args)
        {
            mywindow.Icon = new BitmapImage(new Uri(@"C:\myicon.ico"));
        }
    }
}
