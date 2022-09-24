using System.Drawing;
using System.Windows.Forms;
using PhasmophobiaHandbook.Properties;
using PhasmophobiaHandbook.Structs.Base;

namespace PhasmophobiaHandbook.Forms
{
    public partial class MapInfo : Form
    {
        private string[] sizes = new string[] { "Small", "Medium", "Large" };
        private Map m;
        private int offset = 37;

        public MapInfo(Map map)
        {
            InitializeComponent();
            m = map;
            Size = new Size(m.Image.Size.Width, m.Image.Size.Height + offset);
            CenterToScreen();
            BringToFront();
            ImgMapOne.Image = m.Image;
            ImgMapOne.Size = new Size(Size.Width, Size.Height - offset);
            Icon = Resources.icon;
            Text = $"Map Info | {m.Name}";
            LblSize.BringToFront();
            LblSize.ForeColor = Color.White;
            LblSize.BackColor = Color.Black;
            LblSize.Text = $"{sizes[(int)m.Size]} map";
            LblSize.Location = new Point(Size.Width - 150, 22);
        }
    }
}
