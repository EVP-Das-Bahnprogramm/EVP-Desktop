using Octokit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Updatum;

namespace EVP.Setup
{
	public partial class UpdateForm : Form
	{
		internal static readonly UpdatumManager AppUpdater = new("EVP-Das-Bahnprogramm", "EVP-Desktop")
		{
			InstallUpdateWindowsInstallerArguments = "/qb" // Displays a basic user interface for MSI package
		};

		public UpdateForm()
		{
			InitializeComponent();
		}

		private void UpdateForm_Load(object sender, EventArgs e)
		{
			ChangeLog.Text = AppUpdater.GetChangelog();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void installButton_Click(object sender, EventArgs e)
		{
			var downloadedAsset = await AppUpdater.DownloadUpdateAsync();

			if (downloadedAsset == null)
			{
				MessageBox.Show("Das Update konnte nicht heruntergeladen werden. Bitte versuchen Sie es später erneut.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// You can manually handle the installation or call the Install method:
			// Returns false if the installation failed ortherwise it will never return true as the process will be terminated to complete the installation.
			await AppUpdater.InstallUpdateAsync(downloadedAsset);
		}
	}
}
