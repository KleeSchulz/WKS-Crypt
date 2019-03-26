using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WKS_Crypt
{
    public partial class Entschluesselung : Form
    {
        public Entschluesselung()
        {
            InitializeComponent();
            cb_art.SelectedIndexChanged += cb_art_SelectedIndexChanged;
			tb_verschluesselt.TextChanged += tb_verschluesselt_TextChanged;
        }

		private void entschluesselung_Load(object sender, EventArgs e)
		{
			cb_art.SelectedIndex = 0;
		}

		private void tb_verschluesselt_TextChanged(object sender, EventArgs e)
		{
			try
			{
				switch (cb_art.SelectedIndex)
				{
					// AES
					case 0:
						tb_entschluesselt.Text = AES.Decrypt(tb_verschluesselt.Text);
						break;
					// RSA
					case 1:
						//tb_entschluesselt.Text = RSA.Decryption(tb_normal.Text);
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
						tb_entschluesselt.Text = AES.Decrypt(tb_verschluesselt.Text);
						break;
					// RSA
					case 1:
						//tb_entschluesselt.Text = RSA.Decryption(tb_normal.Text);
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
