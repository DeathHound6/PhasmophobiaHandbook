using System;
using System.Media;
using System.Windows.Forms;
using PhasmophobiaHandbook.Structs.Base;
using PhasmophobiaHandbook.Properties;

namespace PhasmophobiaHandbook.Forms
{
    public partial class GhostInfo : Form
    {
        private string[] evidences = new string[] {"EMF 5", "DOTS Projector", "Fingerprints", "Ghost Orbs", "Ghost Writing", "Spirit Box", "Freezing Temperatures"};
        private Ghost g;
        private SoundPlayer player;

        public GhostInfo(Ghost ghost)
        {
            InitializeComponent();
            g = ghost;
            CenterToScreen();
            BringToFront();
            Icon = Resources.icon;
            BringToFront();
            Text = $"Ghost Info | {g.Name}";
            LblName.Text = g.Name;
            try
            {
                LblEvidenceOne.Text = evidences[(int)g.Evidences[0]];
                LblEvidenceOne.Visible = true;
                LblEvidenceTwo.Text = evidences[(int)g.Evidences[1]];
                LblEvidenceTwo.Visible = true;
                LblEvidenceThree.Text = evidences[(int)g.Evidences[2]];
                LblEvidenceThree.Visible = true;
                LblEvidenceFour.Text = evidences[(int)g.Evidences[3]];
                LblEvidenceFour.Visible = true;
            }
            catch (IndexOutOfRangeException) { }
            foreach (string note in g.Notes)
            {
                TxtNotes.AppendText($"- {note}\n");
                TxtNotes.AppendText(Environment.NewLine);
            }
            if (g.Notes.Length > 0)
                TxtNotes.Visible = true;
            try
            {
                LblAudioOne.Text = g.Audio[0][0];
                LblAudioOne.Visible = true;
                ImgAudioOne.Visible = true;
                LblAudioTwo.Text = g.Audio[1][0];
                LblAudioTwo.Visible = true;
                ImgAudioTwo.Visible = true;
                LblAudioThree.Text = g.Audio[2][0];
                LblAudioThree.Visible = true;
                ImgAudioThree.Visible = true;
            }
            catch (IndexOutOfRangeException) {}
        }

        private void ImgAudioOne_Click(object sender, EventArgs e)
        {
            if (player != null)
                player.Stop();
            try
            {
                player = new SoundPlayer(g.Audio[0][1]);
                player.Play();
                player = null;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Failed to find the audio track to play", "Missing Audio Track", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImgAudioTwo_Click(object sender, EventArgs e)
        {
            if (player != null)
                player.Stop();
            try
            {
                player = new SoundPlayer(g.Audio[1][1]);
                player.Play();
                player = null;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Failed to find the audio track to play", "Missing Audio Track", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ImgAudioThree_Click(object sender, EventArgs e)
        {
            if (player != null)
                player.Stop();
            try
            {
                player = new SoundPlayer(g.Audio[2][1]);
                player.Play();
                player = null;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Failed to find the audio track to play", "Missing Audio Track", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
