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
	public partial class homePage : UserControl
	{
		private UserSession session;

		public homePage(UserSession session)
		{

			this.session = session;
			InitializeComponent();
		}
		private async Task LoadSightingsAsync()
		{
			var client = new HttpClient();
			client.DefaultRequestHeaders.Add("apikey", "sb_publishable_FytYync462o0wIBa9FwB6Q_cluc4r9E");
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", session.AccessToken);

			var response = await client.GetAsync("https://orjuxnpbfghidsxurqgq.supabase.co/rest/v1/sichtungen?order=date.desc&limit=10");
			if (!response.IsSuccessStatusCode)
			{
				MessageBox.Show("Fehler beim Laden der Sichtungen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var json = await response.Content.ReadAsStringAsync();
			var sightings = JsonConvert.DeserializeObject<List<Sighting>>(json);

			dataGridView1.DataSource = sightings;
		}

		private async void homePage_Load(object sender, EventArgs e)
		{
			label1.Text = $"Eingeloggt als: {session.Username}";
			await LoadSightingsAsync();

		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			EVP.DataManager.SaveUser(new EVP.User { Username = "default" });
			var parent = this.Parent as mainSF;
			parent?.LoadLogin();
		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private async void timer1_Tick(object sender, EventArgs e)
		{
			await LoadSightingsAsync(); // This is your Supabase query method
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var parentForm = this.FindForm() as mainSF;
			if (parentForm != null)
			{
				var addTrainControl = new addTrain(session); // or pass session however you store it
				parentForm.LoadControl(addTrainControl);
			}
			else
			{
				throw new Exception("Parent form is not of type mainSF");
			}

		}
	}
	public class Sighting
	{
		public string Id { get; set; }
		public string Baureihe { get; set; }
		public string Durch { get; set; }
		public string Nach { get; set; }
		public string Zugnummer { get; set; }
		public string Notizen { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string Wagen { get; set; }
		public DateTime Date { get; set; }
	}
}
