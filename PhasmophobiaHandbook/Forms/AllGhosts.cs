using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PhasmophobiaHandbook.Properties;
using PhasmophobiaHandbook.Structs.Base;
using PhasmophobiaHandbook.Structs.Inherited;

namespace PhasmophobiaHandbook.Forms
{
    public partial class AllGhosts : Form
    {
        private List<GhostEvidence> evidencesChecked = new List<GhostEvidence>();
        public AllGhosts()
        {
            InitializeComponent();
            CenterToScreen();
            BringToFront();
            Icon = Resources.icon;
            Text = "Ghosts List";
            CBoxFilter.Items.Clear();
            CBoxFilter.Items.Add("EMF 5");
            CBoxFilter.Items.Add("DOTS Projector");
            CBoxFilter.Items.Add("Fingerprints");
            CBoxFilter.Items.Add("Ghost Orbs");
            CBoxFilter.Items.Add("Ghost Writing");
            CBoxFilter.Items.Add("Spirit Box");
            CBoxFilter.Items.Add("Freezing Temperatures");
        }

        private void CBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (evidencesChecked.Count == 3 && CBoxFilter.CheckedItems.Count > 3)
            {
                CBoxFilter.SetItemChecked(CBoxFilter.SelectedIndex, false);
                MessageBox.Show("You can only select up to 3 evidences to filter", "Invalid Filter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CBoxFilter.CheckedItems.Count > evidencesChecked.Count)
                evidencesChecked.Add((GhostEvidence)CBoxFilter.SelectedIndex);
            else if (CBoxFilter.CheckedItems.Count < evidencesChecked.Count)
                evidencesChecked.Remove((GhostEvidence)CBoxFilter.SelectedIndex);
            foreach(Ghost ghost in Constants.ghosts)
            {
                Button button = Controls.OfType<Button>().Single(b => b.Text == ghost.Name);
                if (!evidencesChecked.All(ev => ghost.Evidences.Contains(ev)))
                    button.ForeColor = Color.Gray;
                else
                    button.ForeColor = Color.Black;
            }
        }

        private void BtnSpirit_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[0]).Show();
        }

        private void BtnWraith_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[1]).Show();
        }

        private void BtnPhantom_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[2]).Show();
        }

        private void BtnPoltergeist_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[3]).Show();
        }

        private void BtnBanshee_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[4]).Show();
        }

        private void BtnJinn_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[5]).Show();
        }

        private void BtnMare_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[6]).Show();
        }

        private void BtnRevenant_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[7]).Show();
        }

        private void BtnShade_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[8]).Show();
        }

        private void BtnDemon_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[9]).Show();
        }

        private void BtnYurei_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[10]).Show();
        }

        private void BtnOni_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[11]).Show();
        }

        private void BtnYokai_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[12]).Show();
        }

        private void BtnHantu_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[13]).Show();
        }

        private void BtnGoryo_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[14]).Show();
        }

        private void BtnMyling_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[15]).Show();
        }

        private void BtnOnryo_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[16]).Show();
        }

        private void BtnTwins_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[17]).Show();
        }

        private void BtnRaiju_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[18]).Show();
        }

        private void BtnObake_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[19]).Show();
        }

        private void BtnMimic_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[20]).Show();
        }

        private void BtnMoroi_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[21]).Show();
        }

        private void BtnDeogen_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[22]).Show();
        }

        private void BtnThaye_Click(object sender, EventArgs e)
        {
            new GhostInfo(Constants.ghosts[23]).Show();
        }

        private void CBoxFilter_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (Button button in Controls.OfType<Button>())
            {
                button.ForeColor = Color.Black;
            }
        }
    }
}
