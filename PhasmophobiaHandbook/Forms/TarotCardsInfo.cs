using System;
using System.Drawing;
using System.Windows.Forms;
using PhasmophobiaHandbook.Properties;
using PhasmophobiaHandbook.Structs.Base;
using PhasmophobiaHandbook.Structs.Inherited;

namespace PhasmophobiaHandbook.Forms
{
    public partial class TarotCardsInfo : Form
    {
        private CursedItem cards = Constants.cursedItems[5];
        public TarotCardsInfo()
        {
            InitializeComponent();
            CenterToScreen();
            BringToFront();
            Icon = Resources.icon;
            Text = $"Cursed Item Info | {cards.Name}";
            LblName.Text = cards.Name;
            ImgItem.Image = cards.Image;
            foreach (string text in cards.Notes)
            {
                TxtNotes.AppendText($"- {text}");
                TxtNotes.AppendText(Environment.NewLine);
            }
            foreach (TarotCard card in cards.Cards)
            {
                LstCards.Items.Add(card.Name);
            }
            LstCards.SelectedItem = cards.Cards[0].Name;
        }

        private void LstCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            TarotCard card = cards.Cards[LstCards.SelectedIndex];
            TxtCardDescription.Text = card.Effect;
            TxtCardDescription.AppendText($"{Environment.NewLine}{Environment.NewLine}");
            TxtCardDescription.AppendText($"Draw Chance: {card.DrawChance}");
            // disable read only and set back colour to allow changing text colour
            TxtCardDescription.ReadOnly = false;
            TxtCardDescription.BackColor = Color.Gray;
            TxtCardDescription.ForeColor = card.BurnColour;
            TxtCardDescription.ReadOnly = true;
            TxtCardDescription.SelectionStart = 0;
            TxtCardDescription.ScrollToCaret();
            ImgCard.Image = card.Image;
        }
    }
}
