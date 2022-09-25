using System;
using System.Windows.Forms;
using PhasmophobiaHandbook.Properties;
using PhasmophobiaHandbook.Structs.Base;

namespace PhasmophobiaHandbook.Forms
{
    public partial class CursedItemInfo : Form
    {
        private CursedItem Item;
        public CursedItemInfo(CursedItem item)
        {
            InitializeComponent();
            CenterToScreen();
            BringToFront();
            Item = item;
            Text = $"Cursed Item Info | {Item.Name}";
            Icon = Resources.icon;
            LblName.Text = Item.Name;
            foreach (string text in Item.Notes)
            {
                TxtNotes.AppendText($"- {text}");
                TxtNotes.AppendText(Environment.NewLine);
            }
            ImgItem.Image = Item.Image;
        }
    }
}
