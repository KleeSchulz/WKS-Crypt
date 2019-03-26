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
	public partial class Verschluesselung : Form
	{
		public Verschluesselung()
		{
			InitializeComponent();
			cb_art.SelectedIndexChanged += cb_art_SelectedIndexChanged;
			tb_normal.TextChanged += tb_normal_TextChanged;
		}

		private void verschluesselung_Load(object sender, EventArgs e)
		{
			cb_art.SelectedIndex = 0;
		}

		private void tb_normal_TextChanged(object sender, EventArgs e)
		{
			try
			{
				switch (cb_art.SelectedIndex)
				{
					// AES
					case 0:
						tb_verschluesselt.Text = AES.Encrypt(tb_normal.Text);
						break;
					// RSA
					case 1:
						//tb_privateKey.Text = RSA.GetPrivateKey()
						//tb_verschluesselt.Text = RSA.Encryption(tb_normal.Text);
						//RSA.ExportPrivateKey();
						//tb_privateKey.Text = RSA.GetPrivateKey().ToString();
						break;
					// DES
					case 2:
						break;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		private void cb_art_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				switch (cb_art.SelectedIndex)
				{
					// AES
					case 0:
						tb_verschluesselt.Text = AES.Encrypt(tb_normal.Text);
						break;
					// RSA
					case 1:
						//tb_privateKey.Text = RSA.GetPrivateKey()
						//tb_verschluesselt.Text = RSA.Encryption(tb_normal.Text);
						//RSA.ExportPrivateKey();
						//tb_privateKey.Text = RSA.GetPrivateKey().ToString();
						break;
					// DES
					case 2:
						break;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}