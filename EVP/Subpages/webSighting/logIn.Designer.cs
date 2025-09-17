namespace EVP.Subpages.webSighting
{
	partial class logIn
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
			tableLayoutPanel1 = new TableLayoutPanel();
			groupBox1 = new GroupBox();
			logInButton = new Button();
			label2 = new Label();
			logInEmailBox = new TextBox();
			groupBox2 = new GroupBox();
			createAccountButton = new Button();
			label4 = new Label();
			userNameACText = new TextBox();
			emailAccountCreationText = new TextBox();
			label3 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			tableLayoutPanel1.SuspendLayout();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
			tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(716, 382);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(logInButton);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(logInEmailBox);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(352, 376);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Anmelden";
			// 
			// logInButton
			// 
			logInButton.Dock = DockStyle.Bottom;
			logInButton.Location = new Point(3, 335);
			logInButton.Name = "logInButton";
			logInButton.Size = new Size(346, 38);
			logInButton.TabIndex = 2;
			logInButton.Text = "Anmelden";
			logInButton.UseVisualStyleBackColor = true;
			logInButton.Click += LIB_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Bahnschrift", 10F);
			label2.Location = new Point(6, 149);
			label2.Name = "label2";
			label2.Size = new Size(49, 17);
			label2.TabIndex = 1;
			label2.Text = "E-Mail";
			label2.Click += label2_Click;
			// 
			// logInEmailBox
			// 
			logInEmailBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			logInEmailBox.Location = new Point(6, 188);
			logInEmailBox.Name = "logInEmailBox";
			logInEmailBox.Size = new Size(340, 23);
			logInEmailBox.TabIndex = 0;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(createAccountButton);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(userNameACText);
			groupBox2.Controls.Add(emailAccountCreationText);
			groupBox2.Controls.Add(label3);
			groupBox2.Dock = DockStyle.Fill;
			groupBox2.Location = new Point(361, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(352, 376);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Account Erstellen";
			// 
			// createAccountButton
			// 
			createAccountButton.Dock = DockStyle.Bottom;
			createAccountButton.Location = new Point(3, 335);
			createAccountButton.Name = "createAccountButton";
			createAccountButton.Size = new Size(346, 38);
			createAccountButton.TabIndex = 6;
			createAccountButton.Text = "Account Erstellen";
			createAccountButton.UseVisualStyleBackColor = true;
			createAccountButton.Click += createAccountButton_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Bahnschrift", 10F);
			label4.Location = new Point(6, 194);
			label4.Name = "label4";
			label4.Size = new Size(87, 17);
			label4.TabIndex = 5;
			label4.Text = "Nutzername";
			// 
			// userNameACText
			// 
			userNameACText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			userNameACText.Location = new Point(6, 223);
			userNameACText.Name = "userNameACText";
			userNameACText.Size = new Size(340, 23);
			userNameACText.TabIndex = 4;
			// 
			// emailAccountCreationText
			// 
			emailAccountCreationText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			emailAccountCreationText.Location = new Point(6, 162);
			emailAccountCreationText.Name = "emailAccountCreationText";
			emailAccountCreationText.Size = new Size(340, 23);
			emailAccountCreationText.TabIndex = 3;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Bahnschrift", 10F);
			label3.Location = new Point(6, 123);
			label3.Name = "label3";
			label3.Size = new Size(49, 17);
			label3.TabIndex = 3;
			label3.Text = "E-Mail";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bahnschrift SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(47, 27);
			label1.Name = "label1";
			label1.Size = new Size(210, 27);
			label1.TabIndex = 1;
			label1.Text = "EVP WebSichtungen";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.EVPSightings_2x;
			pictureBox1.Location = new Point(14, 26);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(30, 30);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// logIn
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(pictureBox1);
			Controls.Add(label1);
			Controls.Add(tableLayoutPanel1);
			Name = "logIn";
			Size = new Size(716, 382);
			tableLayoutPanel1.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private PictureBox pictureBox1;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Button logInButton;
		private Label label2;
		private TextBox logInEmailBox;
		private Label label3;
		private TextBox userNameACText;
		private TextBox emailAccountCreationText;
		private Label label4;
		private Button createAccountButton;
	}
}
