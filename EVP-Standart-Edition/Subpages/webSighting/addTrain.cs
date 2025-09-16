using EVP.Suppages.webSighting;
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
	public partial class addTrain : UserControl
	{
		private UserSession session;

		public addTrain(UserSession session)
		{
			InitializeComponent();
			this.session = session;
		}

		public void loadStationOptions(ComboBox CB)
		{
			var lines = File.ReadAllLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "stationIndex.csv"));

			foreach (var line in lines)
			{
				var parts = line.Split(';');
				if (parts.Length >= 2)
				{
					var ds100 = parts[0].Trim();
					var longName = parts[1].Trim();
					var shortName = parts[2].Trim();
					var stationType = parts[3].Trim();
					CB.Items.Add($"{ds100} - {shortName} {stationType}");
				}
			}

		}

		private void addTrain_Load(object sender, EventArgs e)
		{
			loadStationOptions(throughBox);
			loadStationOptions(toComboBox);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var HPCtrl = new homePage(session); // Pass session if needed
			var parent = this.Parent as mainSF;
			parent?.LoadControl(HPCtrl);
		}
	}
}
