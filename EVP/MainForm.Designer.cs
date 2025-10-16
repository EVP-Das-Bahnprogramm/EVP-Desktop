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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			toolStrip1 = new ToolStrip();
			evpHomeBtn = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			evpGallBtn = new ToolStripButton();
			evpSightBtn = new ToolStripButton();
			evpPlaceBtn = new ToolStripButton();
			toolStripSeparator3 = new ToolStripSeparator();
			evpPluginButton = new ToolStripButton();
			toolStripSeparator4 = new ToolStripSeparator();
			toolStripLabel1 = new ToolStripLabel();
			menuStrip1 = new MenuStrip();
			eVPToolStripMenuItem = new ToolStripMenuItem();
			aufUpdatesÜberprüfenToolStripMenuItem = new ToolStripMenuItem();
			programmBeendenToolStripMenuItem = new ToolStripMenuItem();
			überEVPToolStripMenuItem = new ToolStripMenuItem();
			hilfeToolStripMenuItem = new ToolStripMenuItem();
			SystrayMain = new NotifyIcon(components);
			SystrayStrip = new ContextMenuStrip(components);
			toolStripMenuItem1 = new ToolStripMenuItem();
			aufUpdatesÜberprüfenToolStripMenuItem1 = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			evpOpen = new ToolStripMenuItem();
			eVPSchließenToolStripMenuItem = new ToolStripMenuItem();
			statusStrip1 = new StatusStrip();
			helpProvider1 = new HelpProvider();
			benutzerToolStripMenuItem = new ToolStripMenuItem();
			dateiToolStripMenuItem = new ToolStripMenuItem();
			bildImportierenToolStripMenuItem = new ToolStripMenuItem();
			plugInImportierenPLXToolStripMenuItem = new ToolStripMenuItem();
			accountInfosAnzeigenToolStripMenuItem = new ToolStripMenuItem();
			benutzerstatistikenToolStripMenuItem = new ToolStripMenuItem();
			überEVPToolStripMenuItem1 = new ToolStripMenuItem();
			eVPHilfeToolStripMenuItem = new ToolStripMenuItem();
			toolStrip1.SuspendLayout();
			menuStrip1.SuspendLayout();
			SystrayStrip.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.Font = new Font("Bahnschrift SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			toolStrip1.ImageScalingSize = new Size(20, 20);
			toolStrip1.Items.AddRange(new ToolStripItem[] { evpHomeBtn, toolStripSeparator1, evpGallBtn, evpSightBtn, evpPlaceBtn, toolStripSeparator3, evpPluginButton, toolStripSeparator4, toolStripLabel1 });
			toolStrip1.Location = new Point(0, 24);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(700, 27);
			toolStrip1.TabIndex = 1;
			toolStrip1.Text = "toolStrip1";
			// 
			// evpHomeBtn
			// 
			evpHomeBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
			evpHomeBtn.Image = Properties.Resources.EVPHome_1kpx;
			evpHomeBtn.ImageTransparentColor = Color.Magenta;
			evpHomeBtn.Name = "evpHomeBtn";
			evpHomeBtn.Size = new Size(24, 24);
			evpHomeBtn.Text = "Startseite";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 27);
			// 
			// evpGallBtn
			// 
			evpGallBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
			evpGallBtn.Image = Properties.Resources.EVPGall_1kpx;
			evpGallBtn.ImageTransparentColor = Color.Magenta;
			evpGallBtn.Name = "evpGallBtn";
			evpGallBtn.Size = new Size(24, 24);
			evpGallBtn.Text = "Gallerie";
			evpGallBtn.Click += toolStripButton4_Click;
			// 
			// evpSightBtn
			// 
			evpSightBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
			evpSightBtn.Image = Properties.Resources.EVPSightings_1kpx;
			evpSightBtn.ImageTransparentColor = Color.Magenta;
			evpSightBtn.Name = "evpSightBtn";
			evpSightBtn.Size = new Size(24, 24);
			evpSightBtn.Text = "Sichtungen";
			evpSightBtn.Click += toolStripButton2_Click;
			// 
			// evpPlaceBtn
			// 
			evpPlaceBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
			evpPlaceBtn.Image = Properties.Resources.EVPPlace_1kpx;
			evpPlaceBtn.ImageTransparentColor = Color.Magenta;
			evpPlaceBtn.Name = "evpPlaceBtn";
			evpPlaceBtn.Size = new Size(24, 24);
			evpPlaceBtn.Text = "Stellen";
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(6, 27);
			// 
			// evpPluginButton
			// 
			evpPluginButton.Image = Properties.Resources.EVPPlugin_1kpx;
			evpPluginButton.ImageTransparentColor = Color.Magenta;
			evpPluginButton.Name = "evpPluginButton";
			evpPluginButton.Size = new Size(76, 24);
			evpPluginButton.Text = "Plug-Ins";
			evpPluginButton.Click += toolStripButton1_Click;
			// 
			// toolStripSeparator4
			// 
			toolStripSeparator4.Name = "toolStripSeparator4";
			toolStripSeparator4.Size = new Size(6, 27);
			// 
			// toolStripLabel1
			// 
			toolStripLabel1.Font = new Font("Bahnschrift Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			toolStripLabel1.Name = "toolStripLabel1";
			toolStripLabel1.Size = new Size(106, 24);
			toolStripLabel1.Text = "Gepinnte Plug-Ins:";
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { eVPToolStripMenuItem, dateiToolStripMenuItem, benutzerToolStripMenuItem, hilfeToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(5, 2, 0, 2);
			menuStrip1.Size = new Size(700, 24);
			menuStrip1.TabIndex = 3;
			menuStrip1.Text = "menuStrip1";
			// 
			// eVPToolStripMenuItem
			// 
			eVPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aufUpdatesÜberprüfenToolStripMenuItem, programmBeendenToolStripMenuItem, überEVPToolStripMenuItem });
			eVPToolStripMenuItem.Name = "eVPToolStripMenuItem";
			eVPToolStripMenuItem.Size = new Size(39, 20);
			eVPToolStripMenuItem.Text = "EVP";
			// 
			// aufUpdatesÜberprüfenToolStripMenuItem
			// 
			aufUpdatesÜberprüfenToolStripMenuItem.Name = "aufUpdatesÜberprüfenToolStripMenuItem";
			aufUpdatesÜberprüfenToolStripMenuItem.Size = new Size(202, 22);
			aufUpdatesÜberprüfenToolStripMenuItem.Text = "Auf Updates Überprüfen";
			aufUpdatesÜberprüfenToolStripMenuItem.Click += aufUpdatesÜberprüfenToolStripMenuItem_Click;
			// 
			// programmBeendenToolStripMenuItem
			// 
			programmBeendenToolStripMenuItem.Name = "programmBeendenToolStripMenuItem";
			programmBeendenToolStripMenuItem.Size = new Size(202, 22);
			programmBeendenToolStripMenuItem.Text = "Programm Beenden";
			// 
			// überEVPToolStripMenuItem
			// 
			überEVPToolStripMenuItem.Name = "überEVPToolStripMenuItem";
			überEVPToolStripMenuItem.Size = new Size(202, 22);
			überEVPToolStripMenuItem.Text = "Über EVP";
			überEVPToolStripMenuItem.Click += überEVPToolStripMenuItem_Click;
			// 
			// hilfeToolStripMenuItem
			// 
			hilfeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { überEVPToolStripMenuItem1, eVPHilfeToolStripMenuItem });
			hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
			hilfeToolStripMenuItem.Size = new Size(44, 20);
			hilfeToolStripMenuItem.Text = "Hilfe";
			// 
			// SystrayMain
			// 
			SystrayMain.ContextMenuStrip = SystrayStrip;
			SystrayMain.Icon = (Icon)resources.GetObject("SystrayMain.Icon");
			SystrayMain.Text = "EVP";
			SystrayMain.Visible = true;
			// 
			// SystrayStrip
			// 
			SystrayStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, aufUpdatesÜberprüfenToolStripMenuItem1, toolStripSeparator2, evpOpen, eVPSchließenToolStripMenuItem });
			SystrayStrip.Name = "SystrayStrip";
			SystrayStrip.Size = new Size(203, 98);
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Enabled = false;
			toolStripMenuItem1.Image = Properties.Resources.EVPHome;
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(202, 22);
			toolStripMenuItem1.Text = "EVP Version Unbekannt";
			// 
			// aufUpdatesÜberprüfenToolStripMenuItem1
			// 
			aufUpdatesÜberprüfenToolStripMenuItem1.Name = "aufUpdatesÜberprüfenToolStripMenuItem1";
			aufUpdatesÜberprüfenToolStripMenuItem1.Size = new Size(202, 22);
			aufUpdatesÜberprüfenToolStripMenuItem1.Text = "Auf Updates Überprüfen";
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(199, 6);
			// 
			// evpOpen
			// 
			evpOpen.Name = "evpOpen";
			evpOpen.Size = new Size(202, 22);
			evpOpen.Text = "EVP Öffnen";
			evpOpen.Click += evpOpen_Click;
			// 
			// eVPSchließenToolStripMenuItem
			// 
			eVPSchließenToolStripMenuItem.Name = "eVPSchließenToolStripMenuItem";
			eVPSchließenToolStripMenuItem.Size = new Size(202, 22);
			eVPSchließenToolStripMenuItem.Text = "EVP Schließen";
			eVPSchließenToolStripMenuItem.Click += eVPSchließenToolStripMenuItem_Click;
			// 
			// statusStrip1
			// 
			statusStrip1.Location = new Point(0, 400);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(700, 22);
			statusStrip1.TabIndex = 5;
			statusStrip1.Text = "statusStrip1";
			// 
			// benutzerToolStripMenuItem
			// 
			benutzerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { accountInfosAnzeigenToolStripMenuItem, benutzerstatistikenToolStripMenuItem });
			benutzerToolStripMenuItem.Name = "benutzerToolStripMenuItem";
			benutzerToolStripMenuItem.Size = new Size(65, 20);
			benutzerToolStripMenuItem.Text = "Benutzer";
			// 
			// dateiToolStripMenuItem
			// 
			dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bildImportierenToolStripMenuItem, plugInImportierenPLXToolStripMenuItem });
			dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
			dateiToolStripMenuItem.Size = new Size(46, 20);
			dateiToolStripMenuItem.Text = "Datei";
			// 
			// bildImportierenToolStripMenuItem
			// 
			bildImportierenToolStripMenuItem.Name = "bildImportierenToolStripMenuItem";
			bildImportierenToolStripMenuItem.Size = new Size(209, 22);
			bildImportierenToolStripMenuItem.Text = "Bild Importieren";
			// 
			// plugInImportierenPLXToolStripMenuItem
			// 
			plugInImportierenPLXToolStripMenuItem.Name = "plugInImportierenPLXToolStripMenuItem";
			plugInImportierenPLXToolStripMenuItem.Size = new Size(209, 22);
			plugInImportierenPLXToolStripMenuItem.Text = "Plug-In Importieren (PLX)";
			// 
			// accountInfosAnzeigenToolStripMenuItem
			// 
			accountInfosAnzeigenToolStripMenuItem.Name = "accountInfosAnzeigenToolStripMenuItem";
			accountInfosAnzeigenToolStripMenuItem.Size = new Size(202, 22);
			accountInfosAnzeigenToolStripMenuItem.Text = "Account-Infos Anzeigen";
			// 
			// benutzerstatistikenToolStripMenuItem
			// 
			benutzerstatistikenToolStripMenuItem.Name = "benutzerstatistikenToolStripMenuItem";
			benutzerstatistikenToolStripMenuItem.Size = new Size(202, 22);
			benutzerstatistikenToolStripMenuItem.Text = "Benutzerstatistiken";
			// 
			// überEVPToolStripMenuItem1
			// 
			überEVPToolStripMenuItem1.Name = "überEVPToolStripMenuItem1";
			überEVPToolStripMenuItem1.Size = new Size(180, 22);
			überEVPToolStripMenuItem1.Text = "Über EVP";
			// 
			// eVPHilfeToolStripMenuItem
			// 
			eVPHilfeToolStripMenuItem.Name = "eVPHilfeToolStripMenuItem";
			eVPHilfeToolStripMenuItem.Size = new Size(180, 22);
			eVPHilfeToolStripMenuItem.Text = "EVP Hilfe";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkGray;
			BackgroundImageLayout = ImageLayout.Zoom;
			ClientSize = new Size(700, 422);
			Controls.Add(statusStrip1);
			Controls.Add(toolStrip1);
			Controls.Add(menuStrip1);
			DoubleBuffered = true;
			Icon = (Icon)resources.GetObject("$this.Icon");
			IsMdiContainer = true;
			MainMenuStrip = menuStrip1;
			Name = "MainForm";
			Text = "EVP - Das Bahnprogramm";
			FormClosing += MainForm_FormClosing;
			Load += MainForm_Load;
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			SystrayStrip.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem eVPToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem programmBeendenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem überEVPToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton evpPluginButton;
		private System.Windows.Forms.ToolStripButton evpHomeBtn;
		private System.Windows.Forms.ToolStripButton evpGallBtn;
		private System.Windows.Forms.ToolStripButton evpSightBtn;
		private System.Windows.Forms.ToolStripButton evpPlaceBtn;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private ToolStripMenuItem aufUpdatesÜberprüfenToolStripMenuItem;
		private ToolStripMenuItem hilfeToolStripMenuItem;
		private ToolStripLabel toolStripLabel1;
		private ToolStripSeparator toolStripSeparator4;
		private NotifyIcon SystrayMain;
		private ContextMenuStrip SystrayStrip;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem aufUpdatesÜberprüfenToolStripMenuItem1;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem evpOpen;
		private ToolStripMenuItem eVPSchließenToolStripMenuItem;
		private StatusStrip statusStrip1;
		private HelpProvider helpProvider1;
		private ToolStripMenuItem dateiToolStripMenuItem;
		private ToolStripMenuItem benutzerToolStripMenuItem;
		private ToolStripMenuItem bildImportierenToolStripMenuItem;
		private ToolStripMenuItem plugInImportierenPLXToolStripMenuItem;
		private ToolStripMenuItem accountInfosAnzeigenToolStripMenuItem;
		private ToolStripMenuItem benutzerstatistikenToolStripMenuItem;
		private ToolStripMenuItem überEVPToolStripMenuItem1;
		private ToolStripMenuItem eVPHilfeToolStripMenuItem;
	}
}