namespace EVP
{
	public partial class Welcome : Form
	{
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
		}
	}
}
