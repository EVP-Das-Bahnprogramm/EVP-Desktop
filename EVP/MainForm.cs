using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EVP.src.subpages;

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
        private void auc(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainContainer.Controls.Clear();
            mainContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var confirmResult = MessageBox.Show("EVP Schließen?", "EVP Schließvorgang", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MainForm mainform = new MainForm();
                mainform.Show();
            }
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.Show();
        }

        private void programmBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.CloseProgram();
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Einstellungen sind noch nicht verfügbar.", "Einstellungen", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Einstellungen sind noch nicht verfügbar.", "Einstellungen", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            startPage SP = new startPage();
            auc(SP);
            homeButton.BackColor = SystemColors.ControlLight;
            lastClickedButton = homeButton;
        }
    }
}
