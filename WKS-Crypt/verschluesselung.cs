using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WKS_Crypt
{
    public partial class verschluesselung : Form
    {
        public verschluesselung()
        {
            InitializeComponent();
            cb_art.SelectedIndexChanged += cb_art_SelectedIndexChanged;
            tb_normal.TextChanged += tb_normal_TextChanged;
        }

        private void tb_normal_TextChanged(object sender, EventArgs e)
        {

            if (tb_normal.TextLength < 50)
            {
                tb_verschluesselt.Text = RSA.Encryption(tb_normal.Text);
            }
        }

        private void cb_art_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_art.SelectedIndex)
            {
                case 0:
                    tb_verschluesselt.Text = EncryptAesManaged(tb_normal.Text);
                    break;
                case 1:
                    //tb_privateKey.Text = RSA.GetPrivateKey()
                    tb_verschluesselt.Text = RSA.Encryption(tb_normal.Text);
                    //RSA.ExportPrivateKey();
                    //tb_privateKey.Text = RSA.GetPrivateKey().ToString();
                    break;
            }
        }

        private void verschluesselung_Load(object sender, EventArgs e)
        {
            cb_art.SelectedText = "AES";
        }

        #region AES

        static string EncryptAesManaged(string verschltext)
        {
            try
            {
                // Create Aes that generates a new key and initialization vector (IV).    
                // Same key must be used in encryption and decryption    
                using (AesManaged aes = new AesManaged())
                {
                    // Encrypt string    
                    byte[] encrypted = Encrypt(verschltext, aes.Key, aes.IV);
                    // Print encrypted string    
                    return ($"{System.Text.Encoding.UTF8.GetString(encrypted)}");

                }
            }
            catch (Exception exp)
            {

                return exp.ToString();
            }
        }

        //Verschlüsselung
        static byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;
            // Create a new AesManaged.    
            using (AesManaged aes = new AesManaged())
            {
                // Create encryptor    
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Create MemoryStream    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
            }
            // Return encrypted data    
            return encrypted;

        }
        static string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = null;
            // Create AesManaged    
            using (AesManaged aes = new AesManaged())
            {
                // Create a decryptor    
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                // Create the streams used for decryption.    
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    // Create crypto stream    
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream    
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }

    }

    #endregion


}