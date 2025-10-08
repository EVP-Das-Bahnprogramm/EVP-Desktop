namespace EVP.Suppages
{
	partial class HomePage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
			pictureBox1 = new PictureBox();
			label1 = new Label();
			flowLayoutPanel1 = new FlowLayoutPanel();
			label2 = new Label();
			panel1 = new Panel();
			linkLabel2 = new LinkLabel();
			linkLabel1 = new LinkLabel();
			label3 = new Label();
			pictureBox2 = new PictureBox();
			groupBox1 = new GroupBox();
			infoText = new Label();
			InfoPanel = new Panel();
			marqueeTimer = new System.Windows.Forms.Timer(components);
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			flowLayoutPanel1.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			InfoPanel.SuspendLayout();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.Logo;
			pictureBox1.Location = new Point(3, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(101, 30);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Fill;
			label1.Location = new Point(3, 36);
			label1.Name = "label1";
			label1.Size = new Size(87, 15);
			label1.TabIndex = 1;
			label1.Text = "Version v0.0.0.0";
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(pictureBox1);
			flowLayoutPanel1.Controls.Add(label1);
			flowLayoutPanel1.Location = new Point(12, 12);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(106, 53);
			flowLayoutPanel1.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Bahnschrift", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(128, 16);
			label2.Name = "label2";
			label2.Size = new Size(242, 46);
			label2.TabIndex = 3;
			label2.Text = "Willkommen!";
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(224, 224, 224);
			panel1.Controls.Add(linkLabel2);
			panel1.Controls.Add(linkLabel1);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(flowLayoutPanel1);
			panel1.Controls.Add(label2);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(700, 76);
			panel1.TabIndex = 4;
			// 
			// linkLabel2
			// 
			linkLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			linkLabel2.AutoSize = true;
			linkLabel2.Font = new Font("Segoe UI", 11.25F);
			linkLabel2.Location = new Point(445, 45);
			linkLabel2.Name = "linkLabel2";
			linkLabel2.Size = new Size(97, 20);
			linkLabel2.TabIndex = 7;
			linkLabel2.TabStop = true;
			linkLabel2.Text = "Einstellungen";
			// 
			// linkLabel1
			// 
			linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			linkLabel1.AutoSize = true;
			linkLabel1.Font = new Font("Segoe UI", 11.25F);
			linkLabel1.Location = new Point(543, 45);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(78, 20);
			linkLabel1.TabIndex = 6;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Abmelden";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(478, 16);
			label3.Name = "label3";
			label3.Size = new Size(141, 20);
			label3.TabIndex = 5;
			label3.Text = "Angemeldet als: xxx";
			label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// pictureBox2
			// 
			pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			pictureBox2.Image = Properties.Resources.EVPDocs;
			pictureBox2.Location = new Point(625, 15);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(50, 50);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			groupBox1.Location = new Point(12, 106);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(203, 304);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = "Neusten Sichtungen";
			// 
			// infoText
			// 
			infoText.AutoSize = true;
			infoText.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			infoText.ForeColor = Color.Black;
			infoText.Location = new Point(2, 3);
			infoText.Name = "infoText";
			infoText.Size = new Size(458, 14);
			infoText.TabIndex = 6;
			infoText.Text = "Willkommen zu EVP Version 0.2! Diese Version wird die Oberfläche für V1 vorbereiten.";
			// 
			// InfoPanel
			// 
			InfoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			InfoPanel.BackColor = SystemColors.ScrollBar;
			InfoPanel.BorderStyle = BorderStyle.FixedSingle;
			InfoPanel.Controls.Add(infoText);
			InfoPanel.Cursor = Cursors.Help;
			InfoPanel.Location = new Point(0, 76);
			InfoPanel.Name = "InfoPanel";
			InfoPanel.Size = new Size(700, 24);
			InfoPanel.TabIndex = 7;
			// 
			// marqueeTimer
			// 
			marqueeTimer.Interval = 1;
			marqueeTimer.Tick += marqueeTimer_Tick;
			// 
			// HomePage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(700, 422);
			Controls.Add(InfoPanel);
			Controls.Add(groupBox1);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "HomePage";
			Text = "Startseite";
			Load += HomePage_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			flowLayoutPanel1.ResumeLayout(false);
			flowLayoutPanel1.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			InfoPanel.ResumeLayout(false);
			InfoPanel.PerformLayout();
			ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private Panel panel1;
		private GroupBox groupBox1;
		private Label infoText;
		private Panel InfoPanel;
		private System.Windows.Forms.Timer marqueeTimer;
		private PictureBox pictureBox2;
		private Label label3;
		private LinkLabel linkLabel2;
		private LinkLabel linkLabel1;
	}
}