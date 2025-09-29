namespace EVP.Setup
{
	partial class UpdateForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel3 = new TableLayoutPanel();
			label2 = new Label();
			groupBox1 = new GroupBox();
			ChangeLog = new RichTextBox();
			tableLayoutPanel2 = new TableLayoutPanel();
			installButton = new Button();
			CloseButton = new Button();
			versionLabel = new Label();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			groupBox1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
			tableLayoutPanel1.Controls.Add(versionLabel, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
			tableLayoutPanel1.Size = new Size(733, 361);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel3.Controls.Add(label2, 0, 0);
			tableLayoutPanel3.Controls.Add(groupBox1, 0, 1);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 54);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 2;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90.90909F));
			tableLayoutPanel3.Size = new Size(727, 251);
			tableLayoutPanel3.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Dock = DockStyle.Fill;
			label2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(3, 0);
			label2.Name = "label2";
			label2.Size = new Size(721, 22);
			label2.TabIndex = 0;
			label2.Text = "Es gibt eine neue EVP-Version. Drücke auf \"Herunterladen um sie Herunterzuladen";
			label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(ChangeLog);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(3, 25);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(721, 223);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Änderungen";
			// 
			// ChangeLog
			// 
			ChangeLog.BackColor = SystemColors.Control;
			ChangeLog.Dock = DockStyle.Fill;
			ChangeLog.Location = new Point(3, 19);
			ChangeLog.Name = "ChangeLog";
			ChangeLog.Size = new Size(715, 201);
			ChangeLog.TabIndex = 0;
			ChangeLog.Text = "";
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Controls.Add(installButton, 0, 0);
			tableLayoutPanel2.Controls.Add(CloseButton, 1, 0);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(3, 311);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel2.Size = new Size(727, 47);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// installButton
			// 
			installButton.Dock = DockStyle.Fill;
			installButton.Location = new Point(3, 3);
			installButton.Name = "installButton";
			installButton.Size = new Size(357, 41);
			installButton.TabIndex = 0;
			installButton.Text = "Installieren";
			installButton.UseVisualStyleBackColor = true;
			installButton.Click += installButton_Click;
			// 
			// CloseButton
			// 
			CloseButton.Dock = DockStyle.Fill;
			CloseButton.Location = new Point(366, 3);
			CloseButton.Name = "CloseButton";
			CloseButton.Size = new Size(358, 41);
			CloseButton.TabIndex = 1;
			CloseButton.Text = "Abbrechen";
			CloseButton.UseVisualStyleBackColor = true;
			CloseButton.Click += CloseButton_Click;
			// 
			// versionLabel
			// 
			versionLabel.AutoSize = true;
			versionLabel.Dock = DockStyle.Fill;
			versionLabel.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			versionLabel.Location = new Point(3, 0);
			versionLabel.Name = "versionLabel";
			versionLabel.Size = new Size(727, 51);
			versionLabel.TabIndex = 1;
			versionLabel.Text = "EVP - Das Bahnprogramm: Neues Update";
			versionLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// UpdateForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(733, 361);
			Controls.Add(tableLayoutPanel1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "UpdateForm";
			Text = "EVP Updatemanager";
			Load += UpdateForm_Load;
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			tableLayoutPanel3.PerformLayout();
			groupBox1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private Label versionLabel;
		private TableLayoutPanel tableLayoutPanel3;
		private Label label2;
		private GroupBox groupBox1;
		private RichTextBox ChangeLog;
		private Button installButton;
		private Button CloseButton;
	}
}