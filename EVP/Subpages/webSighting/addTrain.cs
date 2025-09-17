using EVP.Suppages.webSighting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVP.Subpages.webSighting
{
	public partial class addTrain : UserControl
	{
		private UserSession session;

		public addTrain(UserSession session)
		{
			InitializeComponent();
			this.session = session;
		}

		public void loadStationOptions(ComboBox CB)
		{
			var lines = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "stationIndex.csv"));

			foreach (var line in lines)
			{
				var parts = line.Split(';');
				if (parts.Length >= 2)
				{
					var ds100 = parts[0].Trim();
					var longName = parts[1].Trim();
					var shortName = parts[2].Trim();
					var stationType = parts[3].Trim();
					CB.Items.Add($"{ds100} - {shortName} {stationType}");
				}
			}

		}

		private void addTrain_Load(object sender, EventArgs e)
		{
			loadStationOptions(throughBox);
			loadStationOptions(toComboBox);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var HPCtrl = new homePage(session); // Pass session if needed
			var parent = this.Parent as mainSF;
			parent?.LoadControl(HPCtrl);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private async void button2_Click(object sender, EventArgs e)
		{
			button2.Enabled = false;

			// Validate required fields
			if (throughBox.SelectedItem == null ||
				toComboBox.SelectedItem == null ||
				string.IsNullOrWhiteSpace(BRBox.Text)||
				string.IsNullOrWhiteSpace(coachBox.Text))
			{
				MessageBox.Show("Bitte fülle alle Pflichtfelder aus.", "Fehlende Angaben", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				button2.Enabled = true;
				return;
			}

			var sighting = new
			{
				durch = throughBox.SelectedItem?.ToString(),
				nach = toComboBox.SelectedItem?.ToString(),
				baureihe = BRBox.Text,
				wagen = coachBox.Text,
				notizen = noteBox.Text,
				username = session.Username,
				email = session.Email,
				date = DateTime.UtcNow
			};

			var json = JsonConvert.SerializeObject(sighting);
			var content = new StringContent(json, Encoding.UTF8, "application/json");

			var client = new HttpClient();
			client.DefaultRequestHeaders.Add("apikey", "sb_publishable_FytYync462o0wIBa9FwB6Q_cluc4r9E");
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session.AccessToken);

			var response = await client.PostAsync("https://orjuxnpbfghidsxurqgq.supabase.co/rest/v1/sichtungen", content);

			if (response.IsSuccessStatusCode)
			{
				MessageBox.Show("Sichtung erfolgreich hinzugefügt!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// Go back to homePage
				var parentForm = this.FindForm() as mainSF;
				if (parentForm != null)
				{
					var homePageControl = new homePage(session);
					parentForm.LoadControl(homePageControl);
				}
			}
			else
			{
				MessageBox.Show("Fehler beim Hinzufügen der Sichtung.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			button2.Enabled = true;
		}
	}
}

