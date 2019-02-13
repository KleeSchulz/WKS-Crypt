namespace WKS_Crypt
{
    partial class Hauptmenue
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hauptmenue));
            this.btn_verschluesselung = new System.Windows.Forms.Button();
            this.btn_entschluesselung = new System.Windows.Forms.Button();
            this.btn_beenden = new System.Windows.Forms.Button();
            this.credits = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_verschluesselung
            // 
            this.btn_verschluesselung.Location = new System.Drawing.Point(123, 34);
            this.btn_verschluesselung.Name = "btn_verschluesselung";
            this.btn_verschluesselung.Size = new System.Drawing.Size(134, 62);
            this.btn_verschluesselung.TabIndex = 0;
            this.btn_verschluesselung.Text = "Verschlüsselung";
            this.btn_verschluesselung.UseVisualStyleBackColor = true;
            // 
            // btn_entschluesselung
            // 
            this.btn_entschluesselung.Location = new System.Drawing.Point(123, 140);
            this.btn_entschluesselung.Name = "btn_entschluesselung";
            this.btn_entschluesselung.Size = new System.Drawing.Size(134, 62);
            this.btn_entschluesselung.TabIndex = 1;
            this.btn_entschluesselung.Text = "Entschlüsselung";
            this.btn_entschluesselung.UseVisualStyleBackColor = true;
            // 
            // btn_beenden
            // 
            this.btn_beenden.Location = new System.Drawing.Point(123, 360);
            this.btn_beenden.Name = "btn_beenden";
            this.btn_beenden.Size = new System.Drawing.Size(134, 62);
            this.btn_beenden.TabIndex = 2;
            this.btn_beenden.Text = "Beenden";
            this.btn_beenden.UseVisualStyleBackColor = true;
            // 
            // credits
            // 
            this.credits.Location = new System.Drawing.Point(123, 248);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(134, 62);
            this.credits.TabIndex = 3;
            this.credits.Text = "Credits";
            this.credits.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 248);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(25, 360);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // Hauptmenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.btn_beenden);
            this.Controls.Add(this.btn_entschluesselung);
            this.Controls.Add(this.btn_verschluesselung);
            this.Name = "Hauptmenue";
            this.Text = "WKS-Crypt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_verschluesselung;
        private System.Windows.Forms.Button btn_entschluesselung;
        private System.Windows.Forms.Button btn_beenden;
        private System.Windows.Forms.Button credits;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

