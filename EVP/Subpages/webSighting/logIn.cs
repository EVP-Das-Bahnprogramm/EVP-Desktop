using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EVP.Subpages.webSighting
{
	public partial class logIn : UserControl
	{
		public logIn()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		public event EventHandler<(string email, string username)> OnOtpRequested;

		private async void LIB_Click(object sender, EventArgs e)
		{
			string email = logInEmailBox.Text.Trim();

			var client = new HttpClient();
			client.DefaultRequestHeaders.Add("apikey", "sb_publishable_FytYync462o0wIBa9FwB6Q_cluc4r9E");

			var payload = new { email = email };
			var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

			var response = await client.PostAsync("https://orjuxnpbfghidsxurqgq.supabase.co/auth/v1/otp", content);
			if (response.IsSuccessStatusCode)
			{
				MessageBox.Show("OTP wurde an Ihre E-Mail gesendet.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
				OnOtpRequested?.Invoke(this, (email, "")); // Tell mainSF to load OTPCode.cs
			}
			else
			{
				MessageBox.Show("Fehler beim Senden des OTP. Bitte überprüfen Sie Ihre E-Mail-Adresse.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private async void createAccountButton_Click(object sender, EventArgs e)
		{
			string email = emailAccountCreationText.Text.Trim();
			string displayName = userNameACText.Text.Trim(); // assuming you have this TextBox

			// 🔐 Validation
			if (string.IsNullOrWhiteSpace(displayName))
			{
				MessageBox.Show("Display name darf nicht leer sein.");
				return;
			}

			if (displayName.Length < 4)
			{
				MessageBox.Show("Display name muss mindestens 4 Zeichen lang sein.");
				return;
			}

			// 🔍 Check uniqueness via Supabase
			var client = new HttpClient();
			client.DefaultRequestHeaders.Add("apikey", "sb_publishable_FytYync462o0wIBa9FwB6Q_cluc4r9E");

			var response = await client.GetAsync($"https://orjuxnpbfghidsxurqgq.supabase.co/rest/v1/profiles?display_name=eq.{displayName}");

			if (response.IsSuccessStatusCode)
			{
				var json = await response.Content.ReadAsStringAsync();
				if (json.Contains(displayName))
				{
					MessageBox.Show("Display name ist bereits vergeben.");
					return;
				}
			}

			// ✅ Send OTP with display_name
			var payload = new
			{
				email = email,
				options = new
				{
					data = new
					{
						display_name = displayName
					},
					emailRedirectTo = "http://localhost:5000/welcome"
				}
			};

			var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
			var otpResponse = await client.PostAsync("https://orjuxnpbfghidsxurqgq.supabase.co/auth/v1/otp", content);

			if (otpResponse.IsSuccessStatusCode)
			{
				MessageBox.Show("OTP wurde gesendet.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
				OnOtpRequested?.Invoke(this, (email, displayName));
			}
			else
			{
				MessageBox.Show("Fehler beim Senden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void label2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Chemnitz Siegmar", "Mirko E.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
}