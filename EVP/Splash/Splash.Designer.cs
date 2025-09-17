namespace EVP
{
    partial class Splash
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
			timer1 = new System.Windows.Forms.Timer(components);
			progressBar1 = new ProgressBar();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			versionLabel = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// timer1
			// 
			timer1.Enabled = true;
			timer1.Interval = 1;
			timer1.Tick += timer1_Tick;
			// 
			// progressBar1
			// 
			progressBar1.Anchor = AnchorStyles.Bottom;
			progressBar1.Location = new Point(-31, 300);
			progressBar1.Name = "progressBar1";
			progressBar1.Size = new Size(700, 19);
			progressBar1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			pictureBox1.Dock = DockStyle.Fill;
			pictureBox1.Image = Properties.Resources.splash;
			pictureBox1.Location = new Point(0, 0);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(638, 319);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 1;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Location = new Point(0, 284);
			label1.Name = "label1";
			label1.Size = new Size(152, 15);
			label1.TabIndex = 2;
			label1.Text = "Einrichtung wird gestartet...";
			label1.Visible = false;
			// 
			// versionLabel
			// 
			versionLabel.AutoSize = true;
			versionLabel.BackColor = Color.IndianRed;
			versionLabel.Font = new Font("Bahnschrift SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			versionLabel.ForeColor = SystemColors.ControlLightLight;
			versionLabel.Location = new Point(22, 128);
			versionLabel.Name = "versionLabel";
			versionLabel.Size = new Size(64, 17);
			versionLabel.TabIndex = 3;
			versionLabel.Text = "v0.1 Beta";
			// 
			// Splash
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImageLayout = ImageLayout.Zoom;
			ClientSize = new Size(638, 319);
			Controls.Add(versionLabel);
			Controls.Add(label1);
			Controls.Add(progressBar1);
			Controls.Add(pictureBox1);
			DoubleBuffered = true;
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Splash";
			ShowIcon = false;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Splash";
			Load += Splash_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versionLabel;
    }
}