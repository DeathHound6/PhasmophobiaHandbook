using System;
using System.Windows.Forms;
using PhasmophobiaHandbook.Properties;
using PhasmophobiaHandbook.Structs.Base;
using PhasmophobiaHandbook.Structs.Inherited;

namespace PhasmophobiaHandbook.Forms
{
    public partial class SpiritBoxInfo : Form
    {
        private Item i = Constants.items[7];
        public SpiritBoxInfo()
        {
            InitializeComponent();
            CenterToScreen();
            BringToFront();
            Text = $"Item Info | {i.Name}";
            Icon = Resources.icon;
            foreach (string text in i.Notes)
            {
                TxtNotes.AppendText($"- {text}");
                TxtNotes.AppendText(Environment.NewLine);
            }
            foreach (SpiritBoxQuestion q in i.SpiritBoxQuestions)
            {
                LstQuestions.Items.Add(q.Type);
            }
            LstQuestions.SelectedIndex = 0;
            ImgItem.Image = i.Image;
            LblLimit.Text = $"{i.Limit}";
            LblPrice.Text = $"${i.Price}";
            LblStarter.Text = i.Starter ? "Yes" : "No";
        }

        private void LstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            SpiritBoxQuestion question = i.SpiritBoxQuestions[LstQuestions.SelectedIndex];
            TxtQuestions.Clear();
            foreach (string q in question.Questions)
            {
                TxtQuestions.AppendText($"- {q}");
                TxtQuestions.AppendText(Environment.NewLine);
            }
            TxtQuestions.SelectionStart = 0;
            TxtQuestions.ScrollToCaret();
        }
    }
}
