using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_File
{
    public partial class frmAESDemo : Form
    {
        byte[] abc;
        byte[,] table;

        public frmAESDemo()
        {
            InitializeComponent();
        }

        private void frmAESDemo_Load(object sender, EventArgs e)
        {
            rdEncrypt.Checked = true;

            // init abc and table
            abc = new byte[256];
            for (int i = 0; i < 256; i++)
            {
                abc[i] = Convert.ToByte(i);
            }

            table = new byte[256, 256];
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    table[i, j] = abc[(i + j) % 256];
                }
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = od.FileName;
            }
        }

        private void rdEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEncrypt.Checked)
            {
                rdDecypt.Checked = false;
            }
        }

        private void rdDecypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDecypt.Checked)
            {
                rdEncrypt.Checked = false;
            }
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("File does not exist.");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password empty. Please enter your password");
                return;
            }

            // Get file content and key for encrypt/decrypt
            try
            {
                byte[] fileContent = File.ReadAllBytes(txtFilePath.Text);
                byte[] passwordTmp = Encoding.ASCII.GetBytes(txtPassword.Text);
                byte[] keys = new byte[fileContent.Length];
                for (int i = 0; i < fileContent.Length; i++)
                    keys[i] = passwordTmp[i % passwordTmp.Length];

                // Encrypt
                byte[] result = new byte[fileContent.Length];

                if (rdEncrypt.Checked)
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        result[i] = table[keyIndex, valueIndex];
                    }
                }
                // Decrypt
                else
                {
                    for (int i = 0; i < fileContent.Length; i++)
                    {
                        byte value = fileContent[i];
                        byte key = keys[i];
                        int valueIndex = -1, keyIndex = -1;
                        for (int j = 0; j < 256; j++)
                            if (abc[j] == key)
                            {
                                keyIndex = j;
                                break;
                            }
                        for (int j = 0; j < 256; j++)
                            if (table[keyIndex, j] == value)
                            {
                                valueIndex = j;
                                break;
                            }
                        result[i] = abc[valueIndex];
                    }
                }

                // Save result to new file with the same extension
                String fileExt = Path.GetExtension(txtFilePath.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "Files (*" + fileExt + ") | *" + fileExt;
                if (sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, result);
                }
            }
            catch
            {
                MessageBox.Show("File is in use.Close other program is using this file and try again.");
                return;
            }
        }
    }
}
