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

		private void LoadControl(UserControl control)
		{
			panel1.Controls.Clear(); // panelHost ist dein Container
			control.Dock = DockStyle.Fill;
			panel1.Controls.Add(control);
		}
		private void LoadOtpControl(object sender, string email)
		{
			var otp = new OTPCode(email);
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
			LoadLogin();

		}
		private void LoadLogin()
		{
			var login = new logIn();
			login.OnOtpRequested += LoadOtpControl;
			LoadControl(login);
		}

	}
}
