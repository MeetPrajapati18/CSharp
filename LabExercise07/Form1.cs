using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExercise07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            string outputText = string.Empty;

            for(int i = 0; i <= 127; i++)
                outputText += String.Format("{0,-8}{1, 8}{2,9:X2}{3,12}\r\n", 
                              i, (i >= 32 ? (char)i : ' '), i,Convert.ToString(i, 2).PadLeft(8,'0'));


            asciiTextBox.Text = outputText;
            clearStringTextBox.Focus();
        }

        private void ClearStringTextBox_TextChanged(object sender, EventArgs e)
        {
            encryptStringTextBox.Text = clearStringTextBox.Text;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string encrypt = string.Empty;

            foreach (char c in clearStringTextBox.Text)
                encrypt += (char)(c + 1);

            encryptStringTextBox.Text = encrypt;

            encryptButton.Enabled = false;
            decryptButton.Enabled = true;
            clearStringTextBox.Focus();
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string decrypt = string.Empty;

            foreach (char c in encryptStringTextBox.Text)
                decrypt += (char)(c - 1);

            encryptStringTextBox.Text = decrypt;

            encryptButton.Enabled = true;
            decryptButton.Enabled = false;
            clearStringTextBox.Focus();
        }

        /// <summary>
        /// This method used a keyed Caesar alphabet for encryption/decryption
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UseKeyButton_Click(object sender, EventArgs e)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string encrypt = string.Empty;
            string fullKey = string.Empty;

            // Build a full key using only unique characters in the textbox key
            foreach (char c in keyTextBox.Text)
                if (fullKey.IndexOf(c) == -1)
                    fullKey += c;

            // Add to the end of the full key all unused letters that were not in the key
            foreach (char c in alphabet)
            {
                int pos = fullKey.IndexOf(c);
                if (pos < 0)
                    fullKey += c;
            }

            // Encrypt
            if (encryptButton.Enabled)
            {
                foreach (char c in clearStringTextBox.Text)
                {
                    int pos = alphabet.IndexOf(c);
                    if (pos >= 0)
                        encrypt += fullKey[pos];
                    else
                        encrypt += c;
                }
            }
            // Decrypt
            else
            {
                foreach (char c in encryptStringTextBox.Text)
                {
                    int pos = fullKey.IndexOf(c);
                    if (pos >= 0)
                        encrypt += alphabet[pos];
                    else
                        encrypt += c;
                }
            }

            encryptStringTextBox.Text = encrypt;

            encryptButton.Enabled = !encryptButton.Enabled;
            decryptButton.Enabled = !decryptButton.Enabled;
        }
    }
}
