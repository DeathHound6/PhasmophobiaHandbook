using System;
using System.Media;
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
            SystemSounds.Beep.Play();
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

        private void BtnCursedItems_Click(object sender, EventArgs e)
        {
            new AllCursedItems().Show();
        }

        private void BtnCredits_Click(object sender, EventArgs e)
        {
            new Credits().Show();
        }

        private void BtnItems_Click(object sender, EventArgs e)
        {
            new AllItems().Show();
        }
    }
}
