namespace WKS_Crypt
{
    partial class Credits
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
			this.rtb_credits = new System.Windows.Forms.RichTextBox();
			this.lbl_title_credits = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rtb_credits
			// 
			this.rtb_credits.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.rtb_credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtb_credits.Location = new System.Drawing.Point(48, 94);
			this.rtb_credits.Name = "rtb_credits";
			this.rtb_credits.ReadOnly = true;
			this.rtb_credits.Size = new System.Drawing.Size(698, 214);
			this.rtb_credits.TabIndex = 0;
			this.rtb_credits.Text = resources.GetString("rtb_credits.Text");
			// 
			// lbl_title_credits
			// 
			this.lbl_title_credits.AutoSize = true;
			this.lbl_title_credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_title_credits.Location = new System.Drawing.Point(45, 35);
			this.lbl_title_credits.Name = "lbl_title_credits";
			this.lbl_title_credits.Size = new System.Drawing.Size(114, 25);
			this.lbl_title_credits.TabIndex = 1;
			this.lbl_title_credits.Text = "WKS-Crypt";
			// 
			// Credits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lbl_title_credits);
			this.Controls.Add(this.rtb_credits);
			this.Name = "Credits";
			this.Text = "Credits";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.RichTextBox rtb_credits;
		private System.Windows.Forms.Label lbl_title_credits;
	}
}