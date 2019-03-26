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
    public partial class Hauptmenue : Form
    {
        public Hauptmenue()
        {
            InitializeComponent();
        }

        private void btn_verschluesselung_Click(object sender, EventArgs e)
        {
            Verschluesselung verschluesselung = new Verschluesselung();
            verschluesselung.Show();
        }

        private void btn_entschluesselung_Click(object sender, EventArgs e)
        {
            Entschluesselung entschluesselung = new Entschluesselung();
            entschluesselung.Show();
        }

		private void btn_credits_Click(object sender, EventArgs e)
		{
			Credits credits = new Credits();
			credits.Show();
		}

		private void btn_beenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
	}
}
