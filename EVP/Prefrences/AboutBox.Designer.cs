namespace EVP
{
    partial class AboutBox
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.AboutSplash;
			pictureBox1.Location = new Point(324, -1);
			pictureBox1.Margin = new Padding(0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(187, 330);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// AboutBox
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(508, 326);
			Controls.Add(pictureBox1);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AboutBox";
			Padding = new Padding(10);
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Über EVP";
			Load += AboutBox1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);

		}

		#endregion

		private PictureBox pictureBox1;
	}
}
