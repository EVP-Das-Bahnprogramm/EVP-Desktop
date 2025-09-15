using System.Globalization;
using System.Resources;

namespace EVP
{
	public partial class Settings : Form
	{
		private ResourceManager resourceManager = new ResourceManager("EVP.Resources", typeof(Settings).Assembly);

		public Settings()
		{
			InitializeComponent();
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			languageBox.SelectedIndex = 0; // Standard: DE-DE
		}

		private void languageBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (languageBox.SelectedItem.ToString() == "Deutsch")
			{
				SetLanguage("de");
			}
			else if (languageBox.SelectedItem.ToString() == "English")
			{
				SetLanguage("en");
			}
			else
			{
				MessageBox.Show(resourceManager.GetString("MessageError_Text"), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			// eier lecken diese scheiße ist kaputt
			// TODO: das hier irgendwie reparieren
		}

		private void SetLanguage(string culture)
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);

			// Formular neu initialisieren, damit die Texte neu geladen werden
			Controls.Clear();
			InitializeComponent();
		}
	}
}
