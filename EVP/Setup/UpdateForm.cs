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

		private async void UpdateForm_Load(object sender, EventArgs e)
		{
			await AppUpdater.CheckForUpdatesAsync(); // Sicherstellen, dass das Release geladen ist
			ChangeLog.Text = AppUpdater.GetChangelog();
			versionLabel.Text = AppUpdater.LatestRelease.Name.ToString();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void installButton_Click(object sender, EventArgs e)
		{
			try
			{
				await AppUpdater.CheckForUpdatesAsync(); // Sicherstellen, dass das Release geladen ist

				var downloadedAsset = await AppUpdater.DownloadUpdateAsync();

				if (downloadedAsset == null)
				{
					MessageBox.Show("Das Update konnte nicht heruntergeladen werden. Prüfe die Asset-URL oder GitHub-Tag.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				// Installation starten
				var confirm = MessageBox.Show(
					"um EVP zu Installieren muss EVP neu gestartet werden.",
					"EVP - Das Bahnprogramm",
					MessageBoxButtons.OKCancel,
					MessageBoxIcon.Warning);
				if (confirm == DialogResult.OK) await AppUpdater.InstallUpdateAsync(downloadedAsset); else return;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Fehler beim Update: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine(ex);
			}
		}
	}
}
