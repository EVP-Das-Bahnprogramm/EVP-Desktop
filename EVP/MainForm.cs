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
			GalleryPage galleryPage = new GalleryPage();
			galleryPage.MdiParent = this;
			galleryPage.Show();
			
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
	}
}
