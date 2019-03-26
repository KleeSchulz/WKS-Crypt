namespace WKS_Crypt
{
    partial class Entschluesselung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cb_art = new System.Windows.Forms.ComboBox();
			this.tb_verschluesselt = new System.Windows.Forms.RichTextBox();
			this.tb_entschluesselt = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(39, 241);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(382, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Bitte wählen Sie einen Entschlüsselungsorithmus:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(243, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Verschlüsselten Text eingeben:";
			// 
			// cb_art
			// 
			this.cb_art.FormattingEnabled = true;
			this.cb_art.Items.AddRange(new object[] {
            "AES",
            "RSA",
            "DES"});
			this.cb_art.Location = new System.Drawing.Point(43, 277);
			this.cb_art.Name = "cb_art";
			this.cb_art.Size = new System.Drawing.Size(121, 24);
			this.cb_art.TabIndex = 8;
			// 
			// tb_verschluesselt
			// 
			this.tb_verschluesselt.Location = new System.Drawing.Point(40, 59);
			this.tb_verschluesselt.Name = "tb_verschluesselt";
			this.tb_verschluesselt.Size = new System.Drawing.Size(716, 159);
			this.tb_verschluesselt.TabIndex = 7;
			this.tb_verschluesselt.Text = "";
			// 
			// tb_entschluesselt
			// 
			this.tb_entschluesselt.Location = new System.Drawing.Point(40, 326);
			this.tb_entschluesselt.Name = "tb_entschluesselt";
			this.tb_entschluesselt.Size = new System.Drawing.Size(716, 159);
			this.tb_entschluesselt.TabIndex = 6;
			this.tb_entschluesselt.Text = "";
			// 
			// Entschluesselung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 529);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cb_art);
			this.Controls.Add(this.tb_verschluesselt);
			this.Controls.Add(this.tb_entschluesselt);
			this.Name = "Entschluesselung";
			this.Text = "Entschlüsselung";
			this.Load += new System.EventHandler(this.entschluesselung_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_art;
        public System.Windows.Forms.RichTextBox tb_verschluesselt;
        public System.Windows.Forms.RichTextBox tb_entschluesselt;
    }
}