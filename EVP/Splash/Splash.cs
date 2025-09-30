namespace EVP
{
	public partial class Splash : Form
	{
		public Splash()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			progressBar1.Increment(1);
			if (progressBar1.Value == 100)
			{
				timer1.Enabled = false;
				if (!Directory.Exists(Program.userDataFolderPath))
				{
					Welcome welc = new Welcome();
					welc.Show();
					Hide();
				}
				else
				{
					MainForm Main = new MainForm();
					Main.Show();
					Hide();
				}
			}

		}

		private void Splash_Load(object sender, EventArgs e)
		{
			versionLabel.Text = "v" + Application.ProductVersion;
			if (!Directory.Exists(Program.userDataFolderPath))
			{
				label1.Visible = true;
			}

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
