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
    public partial class AllMaps : Form
    {
        private int index = -1;
        public AllMaps()
        {
            InitializeComponent();
            CenterToScreen();
            BringToFront();
            Icon = Resources.icon;
            Text = "Maps List";
        }

        private void CBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = CBoxFilter.SelectedIndex;
            foreach (Button btn in Controls.OfType<Button>())
            {
                btn.ForeColor = Color.Black;
            }
            if (selected != index && index != -1)
                CBoxFilter.SetItemChecked(index, false);
            index = CBoxFilter.CheckedIndices.Count > 0 ? CBoxFilter.CheckedIndices[0] : -1;
            if (index == -1)
                return;
            List<Map> filtered = Constants.maps.FindAll(m => {
                return m.Size != (MapSize)index;
            });
            foreach (Map map in filtered)
            {
                Controls.OfType<Button>().Single(button => button.Text == map.Name).ForeColor = Color.Gray;
            }
        }

        private void BtnBrownstone_Click(object sender, EventArgs e)
        {
            new MapInfo(Constants.maps[2]).Show();
        }

        private void BtnAsylum_Click(object sender, EventArgs e)
        {
            new MapInfo(Constants.maps[0]).Show();
        }

        private void BtnBleasedale_Click(object sender, EventArgs e)
        {
            new MapInfo(Constants.maps[1]).Show();
        }

        private void BtnEdgefield_Click(object sender, EventArgs e)
        {
            new MapInfo(Constants.maps[3]).Show();
        }

        private void BtnGrafton_Click(object sender, EventArgs e)
        {
            new MapInfo(Constants.maps[4]).Show();
        }

        private void BtnCampsite_Click(object sender, EventArgs e)
        {
            new MapInfo(Constants.maps[5]).Show();
        }

        private void BtnPrison_Click(object sender, EventArgs e)
        {
            new MapInfo(Constants.maps[6]).Show();
        }

        private void BtnRidgeview_Click(object sender, EventArgs e)
        {
            new MapInfo(Constants.maps[7]).Show();
        }

        private void BtnTanglewood_Click(object sender, EventArgs e)
        {
            new MapInfo(Constants.maps[8]).Show();
        }

        private void BtnWillow_Click(object sender, EventArgs e)
        {
            new MapInfo(Constants.maps[9]).Show();
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
