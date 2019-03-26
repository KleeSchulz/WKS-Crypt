namespace WKS_Crypt
{
    partial class Verschluesselung
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
			this.tb_verschluesselt = new System.Windows.Forms.RichTextBox();
			this.tb_normal = new System.Windows.Forms.RichTextBox();
			this.cb_art = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tb_verschluesselt
			// 
			this.tb_verschluesselt.Location = new System.Drawing.Point(39, 328);
			this.tb_verschluesselt.Name = "tb_verschluesselt";
			this.tb_verschluesselt.Size = new System.Drawing.Size(716, 159);
			this.tb_verschluesselt.TabIndex = 1;
			this.tb_verschluesselt.Text = "";
			// 
			// tb_normal
			// 
			this.tb_normal.Location = new System.Drawing.Point(39, 59);
			this.tb_normal.Name = "tb_normal";
			this.tb_normal.Size = new System.Drawing.Size(716, 159);
			this.tb_normal.TabIndex = 2;
			this.tb_normal.Text = "";
			// 
			// cb_art
			// 
			this.cb_art.FormattingEnabled = true;
			this.cb_art.Items.AddRange(new object[] {
            "AES",
            "RSA",
            "DES"});
			this.cb_art.Location = new System.Drawing.Point(42, 276);
			this.cb_art.Name = "cb_art";
			this.cb_art.Size = new System.Drawing.Size(121, 24);
			this.cb_art.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Text eingeben:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 237);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(405, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Bitte wählen Sie einen Verschlüsselungsalgorithmus:";
			// 
			// Verschluesselung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 529);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cb_art);
			this.Controls.Add(this.tb_normal);
			this.Controls.Add(this.tb_verschluesselt);
			this.Name = "Verschluesselung";
			this.Text = "Verschlüsselung";
			this.Load += new System.EventHandler(this.verschluesselung_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox tb_verschluesselt;
        public System.Windows.Forms.RichTextBox tb_normal;
        public System.Windows.Forms.ComboBox cb_art;
        public System.Windows.Forms.Label label2;
    }
}