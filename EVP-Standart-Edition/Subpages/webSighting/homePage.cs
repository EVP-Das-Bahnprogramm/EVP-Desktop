using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVP.Subpages.webSighting
{
	public partial class homePage : UserControl
	{
		private UserSession session;

		public homePage(UserSession session)
		{

			this.session = session;
			InitializeComponent();
		}

		private void homePage_Load(object sender, EventArgs e)
		{
			label1.Text = $"Willkommen, {session.Username}";

		}
	}
}
