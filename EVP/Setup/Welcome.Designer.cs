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
			this.Sprache = new System.Windows.Forms.Label();
			this.languageBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.userName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// welcomeSign
			// 
			resources.ApplyResources(this.welcomeSign, "welcomeSign");
			this.welcomeSign.Name = "welcomeSign";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::EVP.Properties.Resources.Logo;
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// NewProfile
			// 
			resources.ApplyResources(this.NewProfile, "NewProfile");
			this.NewProfile.Name = "NewProfile";
			this.NewProfile.UseVisualStyleBackColor = true;
			this.NewProfile.Click += new System.EventHandler(this.NewProfile_Init);
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.NewProfile, 0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.userName);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.Sprache);
			this.panel1.Controls.Add(this.languageBox);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// Sprache
			// 
			resources.ApplyResources(this.Sprache, "Sprache");
			this.Sprache.Name = "Sprache";
			// 
			// languageBox
			// 
			this.languageBox.FormattingEnabled = true;
			this.languageBox.Items.AddRange(new object[] {
            resources.GetString("languageBox.Items"),
            resources.GetString("languageBox.Items1")});
			resources.ApplyResources(this.languageBox, "languageBox");
			this.languageBox.Name = "languageBox";
			this.languageBox.SelectedIndexChanged += new System.EventHandler(this.languageBox_SelectedIndexChanged);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// userName
			// 
			resources.ApplyResources(this.userName, "userName");
			this.userName.Name = "userName";
			// 
			// Welcome
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.welcomeSign);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Welcome";
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
		private System.Windows.Forms.Label Sprache;
		private System.Windows.Forms.ComboBox languageBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox userName;
	}
}