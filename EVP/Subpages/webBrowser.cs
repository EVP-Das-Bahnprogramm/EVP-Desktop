using EVP.src;

namespace EVP.Suppages
{
	public partial class webBrowser : Form
	{
		string defaultURL = "https://www.google.com";
		public webBrowser()
		{
			InitializeComponent();
		}
		public void LoadGoogleSearch(string query)
		{
			if (!string.IsNullOrWhiteSpace(query))
			{
				// Construct the Google search URL
				string googleSearchUrl = $"https://www.google.com/search?q={Uri.EscapeDataString(query)}";

				// Set the URL in the webView21 control
				webView21.Source = new Uri(googleSearchUrl);

				// Update the search box text
				searchBox.Text = googleSearchUrl;
			}
		}
		private void webBrowser_Load(object sender, EventArgs e)
		{
			IconHelper iconHelper = new IconHelper();
			iconHelper.LoadFileIcon(reloadButton, 238, false, false);
			iconHelper.LoadFileIcon(backButton, 256, false, true);
			iconHelper.LoadFileIcon(nextButton, 252, false, true);
			webView21.Source = new Uri(defaultURL);
			searchBox.Text = webView21.Source.ToString();
		}

		private void reloadButton_Click(object sender, EventArgs e)
		{
			webView21.Reload();
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			webView21.GoBack();
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			webView21.GoForward();
		}

		private void searchBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void webView21_Click(object sender, EventArgs e)
		{

		}
	}
}
