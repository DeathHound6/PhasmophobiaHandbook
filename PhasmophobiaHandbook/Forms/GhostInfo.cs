using System;
using System.IO;
using System.Media;
using System.ComponentModel;
using System.Windows.Forms;
using PhasmophobiaHandbook.Structs.Base;
using PhasmophobiaHandbook.Properties;
using System.Threading.Tasks;

namespace PhasmophobiaHandbook.Forms
{
    public partial class GhostInfo : Form
    {
        private string[] evidences = new string[] {"EMF 5", "DOTS Projector", "Fingerprints", "Ghost Orbs", "Ghost Writing", "Spirit Box", "Freezing Temperatures"};
        private Ghost g;
        private SoundPlayer player;
        private PictureBox lastClicked;

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
                LblAudioOne.Text = (string)g.Audio[0][0];
                LblAudioOne.Visible = true;
                ImgAudioOne.Visible = true;
                LblAudioTwo.Text = (string)g.Audio[1][0];
                LblAudioTwo.Visible = true;
                ImgAudioTwo.Visible = true;
                LblAudioThree.Text = (string)g.Audio[2][0];
                LblAudioThree.Visible = true;
                ImgAudioThree.Visible = true;
            }
            catch (IndexOutOfRangeException) {}
            LblSanity.Text = g.HuntingSanity;
        }

        private async void ImgAudioOne_Click(object sender, EventArgs e)
        {
            if (lastClicked == ImgAudioOne)
            {
                PlayerCompleted(sender, e);
                return;
            }
            lastClicked = ImgAudioOne;
            if (player != null)
                PlayerCompleted(sender, e);
            try
            {
                ImgAudioOne.Image = Resources.speaker_mute;
                player = new SoundPlayer((UnmanagedMemoryStream)g.Audio[0][1]);
                await Task.Factory.StartNew(() => Play(player, PlayerCompleted));
            }
            catch (IndexOutOfRangeException)
            {
                PlayerCompleted(sender, e);
                MessageBox.Show("Failed to find the audio track to play", "Missing Audio Track", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ImgAudioTwo_Click(object sender, EventArgs e)
        {
            if (lastClicked == ImgAudioTwo)
            {
                PlayerCompleted(sender, e);
                return;
            }
            lastClicked = ImgAudioTwo;
            if (player != null)
                PlayerCompleted(sender, e);
            try
            {
                ImgAudioTwo.Image = Resources.speaker_mute;
                player = new SoundPlayer((UnmanagedMemoryStream)g.Audio[1][1]);
                await Task.Factory.StartNew(() => Play(player, PlayerCompleted));
            }
            catch (IndexOutOfRangeException)
            {
                PlayerCompleted(sender, e);
                MessageBox.Show("Failed to find the audio track to play", "Missing Audio Track", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ImgAudioThree_Click(object sender, EventArgs e)
        {
            if (lastClicked == ImgAudioThree)
            {
                PlayerCompleted(sender, e);
                return;
            }
            lastClicked = ImgAudioThree;
            if (player != null)
                PlayerCompleted(sender, e);
            try
            {
                ImgAudioThree.Image = Resources.speaker_mute;
                player = new SoundPlayer((UnmanagedMemoryStream)g.Audio[2][1]);
                await Task.Factory.StartNew(() => Play(player, PlayerCompleted));
            }
            catch (IndexOutOfRangeException)
            {
                PlayerCompleted(sender, e);
                MessageBox.Show("Failed to find the audio track to play", "Missing Audio Track", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Play(SoundPlayer player, EventHandler callback)
        {
            try
            {
                player.Play();
            }
            catch (InvalidOperationException)
            {
                player.Stop();
                player.Stream.Position = 0;
                player.Dispose();
                player = null;
            }
        }

        private void PlayerCompleted(object sender, EventArgs e)
        {
            ImgAudioOne.Image = Resources.speaker1;
            ImgAudioTwo.Image = Resources.speaker1;
            ImgAudioThree.Image = Resources.speaker1;
            player.Stop();
            player.Stream.Position = 0;
            player.Dispose();
            player = null;
        }
    }
}
