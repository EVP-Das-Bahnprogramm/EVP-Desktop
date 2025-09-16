namespace EVP.Subpages.webSighting
{
	partial class homePage
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
			components = new System.ComponentModel.Container();
			label1 = new Label();
			tableLayoutPanel1 = new TableLayoutPanel();
			linkLabel1 = new LinkLabel();
			button1 = new Button();
			dataGridView1 = new DataGridView();
			tableLayoutPanel2 = new TableLayoutPanel();
			groupBox1 = new GroupBox();
			timer1 = new System.Windows.Forms.Timer(components);
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tableLayoutPanel2.SuspendLayout();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(74, 29);
			label1.TabIndex = 0;
			label1.Text = "label1";
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(linkLabel1, 1, 0);
			tableLayoutPanel1.Controls.Add(button1, 2, 0);
			tableLayoutPanel1.Dock = DockStyle.Top;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(716, 33);
			tableLayoutPanel1.TabIndex = 1;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Font = new Font("Bahnschrift SemiBold", 18F, FontStyle.Bold);
			linkLabel1.Location = new Point(83, 0);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(122, 29);
			linkLabel1.TabIndex = 1;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Abmelden";
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// button1
			// 
			button1.Location = new Point(211, 3);
			button1.Name = "button1";
			button1.Size = new Size(145, 27);
			button1.TabIndex = 2;
			button1.Text = "Sichtung Hinzufügen";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(6, 22);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(340, 315);
			dataGridView1.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(0, 33);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(716, 349);
			tableLayoutPanel2.TabIndex = 3;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(dataGridView1);
			groupBox1.Location = new Point(3, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(352, 343);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Neuste Sichtungen";
			// 
			// timer1
			// 
			timer1.Enabled = true;
			timer1.Interval = 12000;
			timer1.Tick += timer1_Tick;
			// 
			// homePage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel2);
			Controls.Add(tableLayoutPanel1);
			Name = "homePage";
			Size = new Size(716, 382);
			Load += homePage_Load;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tableLayoutPanel2.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private TableLayoutPanel tableLayoutPanel1;
		private LinkLabel linkLabel1;
		private Button button1;
		private DataGridView dataGridView1;
		private TableLayoutPanel tableLayoutPanel2;
		private GroupBox groupBox1;
		private System.Windows.Forms.Timer timer1;
	}
}
