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
            this.zugfahrtenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeButton = new System.Windows.Forms.Button();
            this.photoButton = new System.Windows.Forms.Button();
            this.placesButton = new System.Windows.Forms.Button();
            this.ProgramButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.trainData = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.zugfahrtenToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem,
            this.programmBeendenToolStripMenuItem,
            this.einstellungenToolStripMenuItem});
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            resources.ApplyResources(this.programmToolStripMenuItem, "programmToolStripMenuItem");
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            resources.ApplyResources(this.überToolStripMenuItem, "überToolStripMenuItem");
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // programmBeendenToolStripMenuItem
            // 
            this.programmBeendenToolStripMenuItem.Name = "programmBeendenToolStripMenuItem";
            resources.ApplyResources(this.programmBeendenToolStripMenuItem, "programmBeendenToolStripMenuItem");
            this.programmBeendenToolStripMenuItem.Click += new System.EventHandler(this.programmBeendenToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            resources.ApplyResources(this.einstellungenToolStripMenuItem, "einstellungenToolStripMenuItem");
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // bildereintragToolStripMenuItem
            // 
            this.bildereintragToolStripMenuItem.Name = "bildereintragToolStripMenuItem";
            resources.ApplyResources(this.bildereintragToolStripMenuItem, "bildereintragToolStripMenuItem");
            // 
            // berToolStripMenuItem
            // 
            this.berToolStripMenuItem.Name = "berToolStripMenuItem";
            resources.ApplyResources(this.berToolStripMenuItem, "berToolStripMenuItem");
            // 
            // betriebstellenToolStripMenuItem
            // 
            this.betriebstellenToolStripMenuItem.Name = "betriebstellenToolStripMenuItem";
            resources.ApplyResources(this.betriebstellenToolStripMenuItem, "betriebstellenToolStripMenuItem");
            // 
            // zugfahrtenToolStripMenuItem
            // 
            this.zugfahrtenToolStripMenuItem.Name = "zugfahrtenToolStripMenuItem";
            resources.ApplyResources(this.zugfahrtenToolStripMenuItem, "zugfahrtenToolStripMenuItem");
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            resources.ApplyResources(this.hilfeToolStripMenuItem, "hilfeToolStripMenuItem");
            // 
            // homeButton
            // 
            resources.ApplyResources(this.homeButton, "homeButton");
            this.homeButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.homeButton.Name = "homeButton";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // photoButton
            // 
            resources.ApplyResources(this.photoButton, "photoButton");
            this.photoButton.Name = "photoButton";
            this.photoButton.UseVisualStyleBackColor = true;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // placesButton
            // 
            resources.ApplyResources(this.placesButton, "placesButton");
            this.placesButton.Name = "placesButton";
            this.placesButton.UseVisualStyleBackColor = true;
            this.placesButton.Click += new System.EventHandler(this.placesButton_Click);
            // 
            // ProgramButton
            // 
            resources.ApplyResources(this.ProgramButton, "ProgramButton");
            this.ProgramButton.Name = "ProgramButton";
            this.ProgramButton.UseVisualStyleBackColor = true;
            this.ProgramButton.Click += new System.EventHandler(this.ProgramButton_Click);
            // 
            // settingsButton
            // 
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // mainContainer
            // 
            resources.ApplyResources(this.mainContainer, "mainContainer");
            this.mainContainer.BackColor = System.Drawing.SystemColors.Control;
            this.mainContainer.Name = "mainContainer";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EVP.Properties.Resources.Logo;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.Controls.Add(this.ProgramButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.photoButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.homeButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.placesButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.trainData, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 5, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // trainData
            // 
            resources.ApplyResources(this.trainData, "trainData");
            this.trainData.Name = "trainData";
            this.trainData.UseVisualStyleBackColor = true;
            this.trainData.Click += new System.EventHandler(this.trainData_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button placesButton;
        private System.Windows.Forms.Button ProgramButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button photoButton;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button trainData;
		private System.Windows.Forms.ToolStripMenuItem zugfahrtenToolStripMenuItem;
	}
}