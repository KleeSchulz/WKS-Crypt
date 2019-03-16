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
    public partial class entschluesselung : Form
    {
        public entschluesselung()
        {
            InitializeComponent();
            cb_art.SelectedIndexChanged += cb_art_SelectedIndexChanged;
        }

        private void cb_art_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_art.SelectedIndex)
            {
                case 0:
                    
                    break;
                case 1:
                    tb_entschluesselt.Text = RSA.Decryption(tb_normal.Text);
                    break;
            }
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void entschluesselung_Load(object sender, EventArgs e)
        {

        }
    }
}
