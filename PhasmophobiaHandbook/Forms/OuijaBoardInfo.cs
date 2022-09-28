using System;
using System.Windows.Forms;
using PhasmophobiaHandbook.Structs.Base;
using PhasmophobiaHandbook.Structs.Inherited;
using PhasmophobiaHandbook.Properties;

namespace PhasmophobiaHandbook.Forms
{
    public partial class OuijaBoardInfo : Form
    {
        private CursedItem board = Constants.cursedItems[0];
        public OuijaBoardInfo()
        {
            InitializeComponent();
            CenterToScreen();
            BringToFront();
            Icon = Resources.icon;
            Text = $"Cursed Item Info | {board.Name}";
            LblName.Text = board.Name;
            ImgItem.Image = board.Image;
            foreach (OujiaQuestion question in board.Questions)
            {
                LstQuestions.Items.Add(question.Type);
            }
            LstQuestions.SelectedItem = board.Questions[0].Type;
            foreach (string text in board.Notes)
            {
                TxtNotes.AppendText($"- {text}");
                TxtNotes.AppendText(Environment.NewLine);
            }
        }

        private void LstQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            OujiaQuestion question = board.Questions[LstQuestions.SelectedIndex];
            TxtQuestionDescription.Clear();
            TxtQuestionDescription.AppendText(question.Description);
            TxtQuestionDescription.AppendText($"{Environment.NewLine}{Environment.NewLine}");
            TxtQuestionDescription.AppendText($"Sanity Cost: {question.SanityCost}%");
            TxtQuestionDescription.SelectionStart = 0;
            TxtQuestionDescription.ScrollToCaret();

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
