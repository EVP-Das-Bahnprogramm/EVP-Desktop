namespace EVP.Subpages.webSighting
{
	partial class OTPCode
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

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			pictureBox1 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			OTPTextBox = new TextBox();
			logInOTP = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.EVPSightings_2x;
			pictureBox1.Location = new Point(6, 5);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(30, 30);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bahnschrift SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(39, 6);
			label1.Name = "label1";
			label1.Size = new Size(210, 27);
			label1.TabIndex = 3;
			label1.Text = "EVP WebSichtungen";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(6, 105);
			label2.Name = "label2";
			label2.Size = new Size(351, 15);
			label2.TabIndex = 4;
			label2.Text = "Bitte schreiben sie den 6-Stelligen Code hier, um WS Zuzugreifen.";
			// 
			// OTPTextBox
			// 
			OTPTextBox.Location = new Point(6, 123);
			OTPTextBox.Name = "OTPTextBox";
			OTPTextBox.Size = new Size(351, 23);
			OTPTextBox.TabIndex = 5;
			// 
			// logInOTP
			// 
			logInOTP.Dock = DockStyle.Bottom;
			logInOTP.Location = new Point(0, 331);
			logInOTP.Name = "logInOTP";
			logInOTP.Size = new Size(716, 51);
			logInOTP.TabIndex = 6;
			logInOTP.Text = "Anmelden";
			logInOTP.UseVisualStyleBackColor = true;
			logInOTP.Click += logInOTP_Click;
			// 
			// OTPCode
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(logInOTP);
			Controls.Add(OTPTextBox);
			Controls.Add(label2);
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			Name = "OTPCode";
			Size = new Size(716, 382);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private Label label2;
		private TextBox OTPTextBox;
		private Button logInOTP;
	}
}
