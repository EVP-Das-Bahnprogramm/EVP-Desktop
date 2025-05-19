using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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
