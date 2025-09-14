using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EVP.Suppages;
using EVP.Suppages.webSighting;
using Rop.Winforms;

namespace EVP
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			int openForms = Application.OpenForms.OfType<GalleryPage>().Count();
			if (openForms > 4)
			{
				MessageBox.Show("Zu viele Fenster Offen!", "EVP - Das Bahnprogramm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				GalleryPage galleryPage = new GalleryPage();
				galleryPage.MdiParent = this;
				galleryPage.Show();
				galleryPage.WindowState = FormWindowState.Normal;
			}

		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			HomePage homePage = new HomePage();
			homePage.MdiParent = this;
			homePage.Show();
			this.WindowState = FormWindowState.Maximized;
			homePage.WindowState = FormWindowState.Maximized;
		}

		private void toolStripLabel1_Click(object sender, EventArgs e)
		{
			webBrowser webBrowser = new webBrowser();
			webBrowser.MdiParent = this;
			webBrowser.Show();
		}

		private void überEVPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox aboutBox = new AboutBox();
			aboutBox.ShowDialog();
		}

		private void InfoBarTimer_Tick(object sender, EventArgs e)
		{
			infoLabel.Text = $"Version v{Application.ProductVersion} || {DateTime.Now.ToString("F")}";
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			int openForms = Application.OpenForms.OfType<pluginsPage>().Count();
			if (openForms > 4)
			{
				MessageBox.Show("Zu viele Fenster Offen!", "EVP - Das Bahnprogramm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				pluginsPage pluginsPage = new pluginsPage();
				pluginsPage.MdiParent = this;
				pluginsPage.Show();
				pluginsPage.WindowState = FormWindowState.Normal;
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			var confirmResult = MessageBox.Show("EVP Schließen?", "EVP Schließvorgang", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (confirmResult == DialogResult.No)
			{
				e.Cancel = true;
			}
			else
			{
				Application.ExitThread();
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			int openForms = Application.OpenForms.OfType<mainSF>().Count();
			mainSF webSicht = new mainSF();
			if (openForms > 0)
			{
				MessageBox.Show("Zu viele Fenster Offen!", "EVP - Das Bahnprogramm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				webSicht.MdiParent = this;
				webSicht.Show();
				webSicht.WindowState = FormWindowState.Normal;

			}
		}
	}
}
