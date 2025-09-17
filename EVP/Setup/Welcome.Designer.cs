namespace EVP
{
    partial class Welcome
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
			this.welcomeSign = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.NewProfile = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.userName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// welcomeSign
			// 
			this.welcomeSign.AutoSize = true;
			this.welcomeSign.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold);
			this.welcomeSign.Location = new System.Drawing.Point(214, 14);
			this.welcomeSign.Name = "welcomeSign";
			this.welcomeSign.Size = new System.Drawing.Size(460, 57);
			this.welcomeSign.TabIndex = 8;
			this.welcomeSign.Text = "Willkommen zu EVP!";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EVP.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(196, 59);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// NewProfile
			// 
			this.NewProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NewProfile.Location = new System.Drawing.Point(3, 3);
			this.NewProfile.Name = "NewProfile";
			this.NewProfile.Size = new System.Drawing.Size(943, 94);
			this.NewProfile.TabIndex = 9;
			this.NewProfile.Text = "+ Neues Profil Erstellen";
			this.NewProfile.UseVisualStyleBackColor = true;
			this.NewProfile.Click += new System.EventHandler(this.NewProfile_Init);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.NewProfile, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 510);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(949, 100);
			this.tableLayoutPanel1.TabIndex = 11;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.userName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 77);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(949, 427);
			this.panel1.TabIndex = 12;
			// 
			// userName
			// 
			this.userName.Location = new System.Drawing.Point(0, 24);
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(261, 22);
			this.userName.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift", 10.2F);
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 21);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nutzername";
			// 
			// Welcome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(973, 622);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.welcomeSign);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Welcome";
			this.Text = "Willkommen zu EVP";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Welcome_FormClosing);
			this.Load += new System.EventHandler(this.Welcome_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeSign;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NewProfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox userName;
	}
}