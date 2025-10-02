namespace EVP.Suppages
{
	partial class webBrowser
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
			tableLayoutPanel1 = new TableLayoutPanel();
			reloadButton = new Button();
			backButton = new Button();
			nextButton = new Button();
			searchBox = new TextBox();
			webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
			tableLayoutPanel2 = new TableLayoutPanel();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
			tableLayoutPanel1.Controls.Add(reloadButton, 0, 0);
			tableLayoutPanel1.Controls.Add(backButton, 1, 0);
			tableLayoutPanel1.Controls.Add(nextButton, 2, 0);
			tableLayoutPanel1.Location = new Point(3, 3);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Size = new Size(110, 32);
			tableLayoutPanel1.TabIndex = 8;
			// 
			// reloadButton
			// 
			reloadButton.Font = new Font("Microsoft Sans Serif", 16.2F);
			reloadButton.Location = new Point(3, 3);
			reloadButton.Name = "reloadButton";
			reloadButton.Size = new Size(30, 26);
			reloadButton.TabIndex = 3;
			reloadButton.UseVisualStyleBackColor = true;
			reloadButton.Click += reloadButton_Click;
			// 
			// backButton
			// 
			backButton.Font = new Font("Microsoft Sans Serif", 16.2F);
			backButton.Location = new Point(39, 3);
			backButton.Name = "backButton";
			backButton.Size = new Size(30, 26);
			backButton.TabIndex = 2;
			backButton.UseVisualStyleBackColor = true;
			backButton.Click += backButton_Click;
			// 
			// nextButton
			// 
			nextButton.Font = new Font("Microsoft Sans Serif", 16.2F);
			nextButton.Location = new Point(75, 3);
			nextButton.Name = "nextButton";
			nextButton.Size = new Size(32, 26);
			nextButton.TabIndex = 4;
			nextButton.UseVisualStyleBackColor = true;
			nextButton.Click += nextButton_Click;
			// 
			// searchBox
			// 
			searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			searchBox.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			searchBox.Location = new Point(119, 3);
			searchBox.Name = "searchBox";
			searchBox.Size = new Size(702, 30);
			searchBox.TabIndex = 7;
			searchBox.TextChanged += searchBox_TextChanged;
			// 
			// webView21
			// 
			webView21.AllowExternalDrop = true;
			webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			webView21.CreationProperties = null;
			webView21.DefaultBackgroundColor = Color.White;
			webView21.Location = new Point(0, 38);
			webView21.Name = "webView21";
			webView21.Size = new Size(822, 377);
			webView21.Source = new Uri("https://www.google.com", UriKind.Absolute);
			webView21.TabIndex = 6;
			webView21.ZoomFactor = 1D;
			webView21.Click += webView21_Click;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tableLayoutPanel2.ColumnCount = 2;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.Controls.Add(searchBox, 1, 0);
			tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
			tableLayoutPanel2.Location = new Point(0, 0);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 1;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Size = new Size(822, 38);
			tableLayoutPanel2.TabIndex = 10;
			// 
			// webBrowser
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(822, 414);
			Controls.Add(tableLayoutPanel2);
			Controls.Add(webView21);
			Name = "webBrowser";
			Text = "EVP WebBrowser";
			Load += webBrowser_Load;
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)webView21).EndInit();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.Button reloadButton;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.TextBox searchBox;
		private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
	}
}