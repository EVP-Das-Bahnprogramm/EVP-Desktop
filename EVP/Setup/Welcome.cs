using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVP
{
    public partial class Welcome : Form
    {
		private ResourceManager resourceManager = new ResourceManager("EVP.Resources", typeof(Welcome).Assembly);

		public Welcome()
        {
            InitializeComponent();
        }

        private void NewProfile_Init(object sender, EventArgs e)
        {
			Directory.CreateDirectory(Program.userDataFolderPath);
		}

		private void Welcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var confirmResult = MessageBox.Show("EVP Schließen?", "EVP Schließvorgang", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
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
