using System;
using System.Windows.Forms;
using PhasmophobiaHandbook.Properties;
using PhasmophobiaHandbook.Structs.Inherited;

namespace PhasmophobiaHandbook.Forms
{
    public partial class AllCursedItems : Form
    {
        public AllCursedItems()
        {
            InitializeComponent();
            CenterToScreen();
            BringToFront();
            Text = "All Cursed Items";
            Icon = Resources.icon;
        }

        private void BtnMusic_Click(object sender, EventArgs e)
        {
            new CursedItemInfo(Constants.cursedItems[1]).Show();
        }

        private void BtnOujia_Click(object sender, EventArgs e)
        {
            new OuijaBoardInfo().Show();
        }

        private void BtnMirror_Click(object sender, EventArgs e)
        {
            new CursedItemInfo(Constants.cursedItems[2]).Show();
        }

        private void BtnCircle_Click(object sender, EventArgs e)
        {
            new CursedItemInfo(Constants.cursedItems[3]).Show();
        }

        private void BtnDoll_Click(object sender, EventArgs e)
        {
            new CursedItemInfo(Constants.cursedItems[4]).Show();
        }

        private void BtnTarots_Click(object sender, EventArgs e)
        {
            new TarotCardsInfo().Show();
        }
    }
}
