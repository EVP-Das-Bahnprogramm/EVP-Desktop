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

namespace EVP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            welcomeSign.Text = $"Willkommen zu EVP, {Environment.UserName}";
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
