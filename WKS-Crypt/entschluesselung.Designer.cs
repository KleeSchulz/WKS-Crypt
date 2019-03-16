namespace WKS_Crypt
{
    partial class entschluesselung
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
            this.tb_normal = new System.Windows.Forms.RichTextBox();
            this.tb_entschluesselt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bitte wählen Sie einen Entschlüsselungsorithmus";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Text eingeben:";
            // 
            // cb_art
            // 
            this.cb_art.FormattingEnabled = true;
            this.cb_art.Items.AddRange(new object[] {
            "AES",
            "RSA",
            "DES"});
            this.cb_art.Location = new System.Drawing.Point(25, 172);
            this.cb_art.Name = "cb_art";
            this.cb_art.Size = new System.Drawing.Size(121, 24);
            this.cb_art.TabIndex = 8;
            // 
            // tb_normal
            // 
            this.tb_normal.Location = new System.Drawing.Point(12, 46);
            this.tb_normal.Name = "tb_normal";
            this.tb_normal.Size = new System.Drawing.Size(776, 92);
            this.tb_normal.TabIndex = 7;
            this.tb_normal.Text = "";
            // 
            // tb_entschluesselt
            // 
            this.tb_entschluesselt.Location = new System.Drawing.Point(12, 224);
            this.tb_entschluesselt.Name = "tb_entschluesselt";
            this.tb_entschluesselt.Size = new System.Drawing.Size(776, 92);
            this.tb_entschluesselt.TabIndex = 6;
            this.tb_entschluesselt.Text = "";
            // 
            // entschluesselung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_art);
            this.Controls.Add(this.tb_normal);
            this.Controls.Add(this.tb_entschluesselt);
            this.Name = "entschluesselung";
            this.Text = "entschluesselung";
            this.Load += new System.EventHandler(this.entschluesselung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_art;
        public System.Windows.Forms.RichTextBox tb_normal;
        public System.Windows.Forms.RichTextBox tb_entschluesselt;
    }
}