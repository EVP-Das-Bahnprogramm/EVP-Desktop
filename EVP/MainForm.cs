using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EVP.src.subpages;
using System.Xml;
using EVP.Suppages;

namespace EVP
{
    public partial class MainForm : Form
    {
        private Button lastClickedButton;
        public MainForm()
        {
            InitializeComponent();
        }
        private void ResetColor(object sender)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (lastClickedButton != null)
                {
                    lastClickedButton.BackColor = SystemColors.ControlLightLight;
                }
            }
            lastClickedButton = clickedButton;
        }
        public void LoadBrowserUIWithSearch(string query)
        {
            // Create an instance of browserUI
            browserUI browser = new browserUI();
            browser.Dock = DockStyle.Fill;

            // Set the search query in browserUI
            browser.LoadGoogleSearch(query);

            // Clear existing controls in mainContainer
            mainContainer.Controls.Clear();

            // Add browserUI to mainContainer
            mainContainer.Controls.Add(browser);
            browser.BringToFront();
        }

        public void auc(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainContainer.Controls.Clear();
            mainContainer.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            startPage SP = new startPage();
            auc(SP);
            homeButton.BackColor = SystemColors.ControlLight;
            lastClickedButton = homeButton;
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox abt = new AboutBox();
            abt.Show();
        }
        private void programmBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.CloseProgram();
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsPage = new Settings();
            settingsPage.Show(); // Corrected the variable name to "settingsPage"  
        }

        private void ProgramButton_Click(object sender, EventArgs e)
        {
            ResetColor(sender);
            programPage programPage = new programPage();
            auc(programPage);
            ProgramButton.BackColor = SystemColors.ControlLight;

        }
        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settingsPage = new Settings();
            settingsPage.Show(); // Corrected the variable name to "settingsPage"  
        }
        private void placesButton_Click(object sender, EventArgs e)
        {
            ResetColor(sender);
            placesPage placesPage = new placesPage();
            auc(placesPage);
            placesButton.BackColor = SystemColors.ControlLight;
        }

        private void photoButton_Click(object sender, EventArgs e)
        {
            ResetColor(sender);
            gallPage GP = new gallPage();
            auc(GP);
            photoButton.BackColor = SystemColors.ControlLight;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ResetColor(sender);
            startPage SP = new startPage();
            auc(SP);
            homeButton.BackColor = SystemColors.ControlLight;
        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
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
        // TODO: noch diese dinger hier löschen


		private void trainData_Click(object sender, EventArgs e)
		{

		}
	}
}
