using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVP.Subpages.webSighting
{
	public partial class OTPCode : UserControl
	{
		public event EventHandler<UserSession> OnOtpVerified;
		private string email;
		private string usernameFromSignup;

		public OTPCode(string email, string username)
		{
			InitializeComponent();
			this.email = email;
			this.usernameFromSignup = username;
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
			if (string.IsNullOrWhiteSpace(username))
			{
				var patchPayload = new
				{
					data = new
					{
						username = usernameFromSignup
					}
				};

				var patchContent = new StringContent(JsonConvert.SerializeObject(patchPayload), Encoding.UTF8, "application/json");
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

				var patchResponse = await client.PutAsync("https://orjuxnpbfghidsxurqgq.supabase.co/auth/v1/user", patchContent);
				if (patchResponse.IsSuccessStatusCode)
				{
					username = usernameFromSignup;
				}
			}

			string emailConfirmed = user.email;

			var userSession = new UserSession
			{
				Email = emailConfirmed,
				Username = username,
				AccessToken = accessToken
			};

			// ✅ Save session for persistent login
			var userToSave = new EVP.User
			{
				Username = username,
				AccountEmail = emailConfirmed,
				AuthToken = accessToken
			};

			EVP.DataManager.SaveUser(userToSave);

			OnOtpVerified?.Invoke(this, userSession);
		}
	}
}