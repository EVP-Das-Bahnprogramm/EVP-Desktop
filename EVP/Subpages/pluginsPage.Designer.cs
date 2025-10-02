namespace EVP.Suppages
{
	partial class pluginsPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pluginsPage));
			pictureBox1 = new PictureBox();
			label1 = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			groupBox3 = new GroupBox();
			label2 = new Label();
			linkLabel1 = new LinkLabel();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.EVPPlugin_2x;
			pictureBox1.Location = new Point(10, 11);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(55, 47);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(71, 14);
			label1.Name = "label1";
			label1.Size = new Size(213, 17);
			label1.TabIndex = 1;
			label1.Text = "Willkommen zur Plug-Ins Seite!";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
			tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
			tableLayoutPanel1.Controls.Add(groupBox3, 1, 1);
			tableLayoutPanel1.Location = new Point(10, 64);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 2;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(679, 347);
			tableLayoutPanel1.TabIndex = 3;
			// 
			// groupBox1
			// 
			tableLayoutPanel1.SetColumnSpan(groupBox1, 2);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(673, 167);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Angepinnt";
			// 
			// groupBox2
			// 
			groupBox2.Dock = DockStyle.Fill;
			groupBox2.Location = new Point(3, 176);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(333, 168);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Installiert";
			// 
			// groupBox3
			// 
			groupBox3.Dock = DockStyle.Fill;
			groupBox3.Location = new Point(342, 176);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(334, 168);
			groupBox3.TabIndex = 2;
			groupBox3.TabStop = false;
			groupBox3.Text = "Standart Plug-Ins";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(71, 41);
			label2.Name = "label2";
			label2.Size = new Size(189, 17);
			label2.TabIndex = 4;
			label2.Text = "Um mehr zu erfahren, clicke";
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Font = new Font("Bahnschrift", 10.2F);
			linkLabel1.Location = new Point(253, 41);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(36, 17);
			linkLabel1.TabIndex = 5;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "hier.";
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			button1.Location = new Point(596, 11);
			button1.Name = "button1";
			button1.Size = new Size(91, 47);
			button1.TabIndex = 6;
			button1.Text = "Plug-In hinzufügen";
			button1.UseVisualStyleBackColor = true;
			// 
			// pluginsPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(700, 422);
			Controls.Add(button1);
			Controls.Add(linkLabel1);
			Controls.Add(label2);
			Controls.Add(tableLayoutPanel1);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "pluginsPage";
			Text = "EVP Plug-ins";
			Load += pluginsPage_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			tableLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button1;
	}
}