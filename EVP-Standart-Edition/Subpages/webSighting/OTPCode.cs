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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EVP.Subpages.webSighting
{
	public partial class OTPCode : UserControl
	{
		public event EventHandler<UserSession> OnOtpVerified;
		private string email;

		public OTPCode(string email)
		{
			InitializeComponent();
			this.email = email;

		}

		private async void logInOTP_Click(object sender, EventArgs e)
		{
			string otp = OTPTextBox.Text.Trim();

			var client = new HttpClient();
			client.DefaultRequestHeaders.Add("apikey", "sb_publishable_FytYync462o0wIBa9FwB6Q_cluc4r9E");

			var payload = new { email = email, token = otp, type = "email" };
			var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

			var response = await client.PostAsync("https://orjuxnpbfghidsxurqgq.supabase.co/auth/v1/verify", content);
			if (!response.IsSuccessStatusCode)
			{
				MessageBox.Show("Fehler bei der OTP-Überprüfung. Bitte überprüfen Sie den Code und versuchen Sie es erneut.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var json = await response.Content.ReadAsStringAsync();
			dynamic session = JsonConvert.DeserializeObject(json);
			string accessToken = session.access_token;

			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
			var userResponse = await client.GetAsync("https://orjuxnpbfghidsxurqgq.supabase.co/auth/v1/user");
			var userJson = await userResponse.Content.ReadAsStringAsync();
			dynamic user = JsonConvert.DeserializeObject(userJson);

			string username = user.user_metadata?.username;
			string emailConfirmed = user.email;

			var userSession = new UserSession
			{
				Email = emailConfirmed,
				Username = username,
				AccessToken = accessToken
			};

			OnOtpVerified?.Invoke(this, userSession);
		}

	}
}
