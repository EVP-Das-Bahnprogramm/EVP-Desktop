using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
