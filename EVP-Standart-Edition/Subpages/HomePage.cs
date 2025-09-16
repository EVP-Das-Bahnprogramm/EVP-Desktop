namespace EVP.Suppages
{
	public partial class HomePage : Form
	{
		public HomePage()
		{
			InitializeComponent();
		}

		private void HomePage_Load(object sender, EventArgs e)
		{
			label1.Text = "Version v" + Application.ProductVersion;
		}
	}
}
