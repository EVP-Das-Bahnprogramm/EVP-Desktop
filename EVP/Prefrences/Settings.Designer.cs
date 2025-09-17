namespace EVP
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.Sprache = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // languageBox
            // 
            resources.ApplyResources(this.languageBox, "languageBox");
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Items.AddRange(new object[] {
            resources.GetString("languageBox.Items"),
            resources.GetString("languageBox.Items1")});
            this.languageBox.Name = "languageBox";
            this.languageBox.SelectedIndexChanged += new System.EventHandler(this.languageBox_SelectedIndexChanged);
            // 
            // Sprache
            // 
            resources.ApplyResources(this.Sprache, "Sprache");
            this.Sprache.Name = "Sprache";
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Sprache);
            this.Controls.Add(this.languageBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.ComboBox languageBox;
		private System.Windows.Forms.Label Sprache;
	}
}