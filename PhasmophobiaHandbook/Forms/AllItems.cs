using System.Windows.Forms;
using PhasmophobiaHandbook.Properties;
using PhasmophobiaHandbook.Structs.Inherited;

namespace PhasmophobiaHandbook.Forms
{
    public partial class AllItems : Form
    {
        public AllItems()
        {
            InitializeComponent();
            CenterToScreen();
            BringToFront();
            Text = "All Items";
            Icon = Resources.icon;
        }

        private void BtnFlash_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[0]).Show();
        }

        private void BtnSFlash_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[1]).Show();
        }

        private void BtnSalt_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[2]).Show();
        }

        private void BtnPhotoCam_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[3]).Show();
        }

        private void BtnVideoCam_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[4]).Show();
        }

        private void BtnTripod_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[5]).Show();
        }

        private void BtnWriting_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[6]).Show();
        }

        private void BtnSpiritBox_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[7]).Show();
        }

        private void BtnCandle_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[8]).Show();
        }

        private void BtnCrucifix_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[9]).Show();
        }

        private void BtnDots_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[10]).Show();
        }

        private void BtnEmf_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[11]).Show();
        }

        private void BtnGlow_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[12]).Show();
        }

        private void BtnHeadCam_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[13]).Show();
        }

        private void BtnLighter_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[14]).Show();
        }

        private void BtnMotion_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[15]).Show();
        }

        private void BtnSound_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[16]).Show();
        }

        private void BtnParaMic_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[17]).Show();
        }

        private void BtnPills_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[18]).Show();
        }

        private void BtnSmudge_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[19]).Show();
        }

        private void BtnThermo_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[20]).Show();
        }

        private void BtnUV_Click(object sender, System.EventArgs e)
        {
            new ItemInfo(Constants.items[21]).Show();
        }
    }
}
