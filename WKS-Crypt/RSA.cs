using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WKS_Crypt
{
    //class RSA
    //{
    //    public static RSACryptoServiceProvider csp;
    //    static RSA()
    //    {
    //        csp = new RSACryptoServiceProvider(2048);
    //    }
    //    public static RSAParameters GetPublicKey()
    //    {
    //        var publicKey = csp.ExportParameters(false);
    //        return publicKey;
    //    }

    //    //public static string ExportPrivateKey()
    //    //{
    //    //    var exportPrivateKey = csp.ExportCspBlob(); // object
    //    //    return exportPrivateKey;
    //    //}

    //    //public static rsaparameters getprivatekey()
    //    //{
    //    //   // var privatekey = csp.exportparameters(true);
    //    //    return privatekey;
    //    //}



    //    public static string Encryption(string text)
    //    {
    //        var pubKey = GetPublicKey();
    //        csp.ImportParameters(pubKey);
    //        var plainTextData = text;
    //        var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(plainTextData);
    //        var bytesCypherText = csp.Encrypt(bytesPlainTextData, false);
    //        var cypherText = Convert.ToBase64String(bytesCypherText);

    //        return cypherText;
    //    }



    //    public static string Decryption(string cypherText)
    //    {
    //        var bytesCypherText = Convert.FromBase64String(cypherText);
    //        var bytesPlainTextData = csp.Decrypt(bytesCypherText, false);
    //        var plainTextData = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);
    //        //var decryptedData = RSA.Decrypt(cypherText, GetPrivateKey(), false);

    //        return plainTextData;
    //    }

    //    public static 


    //}
    class RSA
    {
        byte[] dataToEncrypt = Encoding.ASCII.GetBytes("Verschlüssel mich!");
        



        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try {

                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKeyInfo);
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);

                }
                return encryptedData;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;

                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKeyInfo);
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}