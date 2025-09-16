using EVP.Subpages.webSighting;

namespace EVP.Suppages.webSighting
{
	public partial class mainSF : Form
	{
		private UserSession currentSession;
		public mainSF()
		{
			InitializeComponent();
		}

		public void LoadControl(UserControl control)
		{
			panel1.Controls.Clear(); // panelHost ist dein Container
			control.Dock = DockStyle.Fill;
			panel1.Controls.Add(control);
		}
		private void LoadOtpControl(object sender, (string email, string username) args)
		{
			var otp = new OTPCode(args.email, args.username);
			otp.OnOtpVerified += HandleOtpVerified;
			LoadControl(otp);
		}
		private void HandleOtpVerified(object sender, UserSession session)
		{
			currentSession = session;
			LoadControl(new homePage(session)); // Oder addTrain, je nach Flow
		}
		private void mainSF_Load(object sender, EventArgs e)
		{
			var user = EVP.DataManager.LoadUser();
			if (user != null && user.IsWebLinked)
			{
				var session = new UserSession
				{
					Username = user.Username,
					Email = user.AccountEmail,
					AccessToken = user.AuthToken
				};

				currentSession = session;
				LoadControl(new homePage(session));
				return;
			}

			LoadLogin();
		}
		public void LoadLogin()
		{
			var login = new logIn();
			login.OnOtpRequested += LoadOtpControl;
			LoadControl(login);
		}

	}
}
