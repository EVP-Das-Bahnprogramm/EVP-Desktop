namespace EVP.Suppages
{
	public partial class HomePage : Form
	{
		public HomePage()
		{
			InitializeComponent();
		}
		enum infoState { Scroll, Pause };
		string[] InfoText = { "EVP - Das Bahnprogramm",
		"Version v" + Application.ProductVersion,
		};
		int pauseCounter = 0;
		int pauseDuration = 60; // ~2 seconds at 30ms
		int scrollSpeed = 1;

		private infoState currentState = infoState.Scroll;

		private void HomePage_Load(object sender, EventArgs e)
		{
			label1.Text = InfoText[1];
			infoText.Text = $"{InfoText[0]} | {InfoText[1]}";
			infoText.Location = new Point(this.Width, 3);
			currentState = infoState.Scroll;
			marqueeTimer.Interval = 20;
			marqueeTimer.Start();

		}

		private void marqueeTimer_Tick(object sender, EventArgs e)
		{
			switch (currentState)
			{
				case infoState.Scroll:
					infoText.Left -= scrollSpeed;

					// Fully off-screen left
					if (infoText.Right < 0)
					{
						currentState = infoState.Pause;
						pauseCounter = 0;

						// Move to pause position (2, 3)
						infoText.Location = new Point(2, 3);
					}
					break;

				case infoState.Pause:
					pauseCounter++;
					if (pauseCounter >= pauseDuration)
					{
						// Reset to off-screen right
						infoText.Location = new Point(this.Width, 3);
						currentState = infoState.Scroll;
					}
					break;
			}

		}

		private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
		{

		}
	}
}
