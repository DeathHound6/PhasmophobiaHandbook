using System;
using System.Windows.Forms;
using PhasmophobiaHandbook.Forms;
using PhasmophobiaHandbook.Properties;

namespace PhasmophobiaHandbook
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            CenterToScreen();
            BringToFront();
            Icon = Resources.icon;
            Text = "Main Menu";
        }

        private void BtnGhosts_Click(object sender, EventArgs e)
        {
            new AllGhosts().Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnMaps_Click(object sender, EventArgs e)
        {
            new AllMaps().Show();
        }
    }
}
