using System;
using System.Windows.Forms;
using PhasmophobiaHandbook.Properties;
using PhasmophobiaHandbook.Structs.Base;

namespace PhasmophobiaHandbook.Forms
{
    public partial class ItemInfo : Form
    {
        public ItemInfo(Item item)
        {
            InitializeComponent();
            CenterToScreen();
            BringToFront();
            Icon = Resources.icon;
            Text = $"Item Info | {item.Name}";
            LblName.Text = item.Name;
            ImgItem.Image = item.Image;
            LblLimit.Text = $"{item.Limit}";
            LblPrice.Text = $"${item.Price}";
            LblStarter.Text = item.Starter ? "Yes" : "No";
            foreach (string text in item.Notes)
            {
                TxtNotes.AppendText($"- {text}");
                TxtNotes.AppendText(Environment.NewLine);
            }
        }
    }
}
