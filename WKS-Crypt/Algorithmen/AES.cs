using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WKS_Crypt
{
	class AES
	{
		private static AesCryptoServiceProvider aesCsp;

		static AES()
		{
			aesCsp = new AesCryptoServiceProvider();
			aesCsp.BlockSize = 128;
			aesCsp.KeySize = 256;
			aesCsp.GenerateKey();
			aesCsp.GenerateIV();
			aesCsp.Mode = CipherMode.CBC;
			aesCsp.Padding = PaddingMode.PKCS7;
		}

		public static string Encrypt(string normalText)
		{
			if (!string.IsNullOrWhiteSpace(normalText))
			{
				ICryptoTransform transform = aesCsp.CreateEncryptor();
				byte[] encryptedBytes = transform.TransformFinalBlock(Encoding.ASCII.GetBytes(normalText), 0, normalText.Length);
				return Convert.ToBase64String(encryptedBytes);
			}
			return string.Empty;
		}

		public static string Decrypt(string encryptedText)
		{
			if (!string.IsNullOrWhiteSpace(encryptedText))
			{
				ICryptoTransform transform = aesCsp.CreateDecryptor();
				byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
				byte[] decryptedBytes = transform.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
				return Encoding.ASCII.GetString(decryptedBytes);
			}
			return string.Empty;
		}
	}
}
