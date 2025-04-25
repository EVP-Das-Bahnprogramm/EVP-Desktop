namespace EVP
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmBeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bildereintragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.berToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.betriebstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.homeButton = new System.Windows.Forms.Button();
            this.placesButton = new System.Windows.Forms.Button();
            this.ProgramButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.photoButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem,
            this.bildereintragToolStripMenuItem,
            this.berToolStripMenuItem,
            this.betriebstellenToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem,
            this.programmBeendenToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.programmToolStripMenuItem.Text = "Programm";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // programmBeendenToolStripMenuItem
            // 
            this.programmBeendenToolStripMenuItem.Name = "programmBeendenToolStripMenuItem";
            this.programmBeendenToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.programmBeendenToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.programmBeendenToolStripMenuItem.Text = "Programm Beenden";
            this.programmBeendenToolStripMenuItem.Click += new System.EventHandler(this.programmBeendenToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.ShortcutKeyDisplayString = "STRG+UMSCH+P";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // bildereintragToolStripMenuItem
            // 
            this.bildereintragToolStripMenuItem.Name = "bildereintragToolStripMenuItem";
            this.bildereintragToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.bildereintragToolStripMenuItem.Text = "Bearbeiten";
            // 
            // berToolStripMenuItem
            // 
            this.berToolStripMenuItem.Name = "berToolStripMenuItem";
            this.berToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.berToolStripMenuItem.Text = "Bildergalerie";
            // 
            // betriebstellenToolStripMenuItem
            // 
            this.betriebstellenToolStripMenuItem.Name = "betriebstellenToolStripMenuItem";
            this.betriebstellenToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.betriebstellenToolStripMenuItem.Text = "Betriebstellen";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.homeButton);
            this.flowLayoutPanel1.Controls.Add(this.photoButton);
            this.flowLayoutPanel1.Controls.Add(this.placesButton);
            this.flowLayoutPanel1.Controls.Add(this.ProgramButton);
            this.flowLayoutPanel1.Controls.Add(this.settingsButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(143, 419);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(3, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(140, 57);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Start";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // placesButton
            // 
            this.placesButton.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placesButton.Location = new System.Drawing.Point(3, 129);
            this.placesButton.Name = "placesButton";
            this.placesButton.Size = new System.Drawing.Size(140, 57);
            this.placesButton.TabIndex = 1;
            this.placesButton.Text = "Stellen";
            this.placesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.placesButton.UseVisualStyleBackColor = true;
            // 
            // ProgramButton
            // 
            this.ProgramButton.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramButton.Location = new System.Drawing.Point(3, 192);
            this.ProgramButton.Name = "ProgramButton";
            this.ProgramButton.Size = new System.Drawing.Size(140, 57);
            this.ProgramButton.TabIndex = 2;
            this.ProgramButton.Text = "Programme";
            this.ProgramButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProgramButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(3, 255);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(140, 57);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "Einst.";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 10);
            this.label1.TabIndex = 1;
            this.label1.Text = "ALPHA";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "2025, David B.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // photoButton
            // 
            this.photoButton.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoButton.Location = new System.Drawing.Point(3, 66);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(140, 57);
            this.photoButton.TabIndex = 4;
            this.photoButton.Text = "Fotos";
            this.photoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.photoButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "MainForm";
            this.Text = "EVP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bildereintragToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem berToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem betriebstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmBeendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button placesButton;
        private System.Windows.Forms.Button ProgramButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button photoButton;
    }
}