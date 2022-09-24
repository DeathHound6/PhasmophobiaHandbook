using System;
using System.Diagnostics;
using System.Windows.Forms;
using PhasmophobiaHandbook.Properties;

namespace PhasmophobiaHandbook.Forms
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
            CenterToScreen();
            BringToFront();
            Icon = Resources.icon;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = false;
                Process.Start("https://phasmo.karotte.org/");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occurred{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = false;
                Process.Start("https://phasmophobia.fandom.com/wiki/Main_Page");
                Process.Start("https://sirjimmothy.github.io/phasmo/");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error has occurred{Environment.NewLine}{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
