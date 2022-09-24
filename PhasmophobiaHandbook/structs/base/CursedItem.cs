using System.Collections.Generic;
using System.Drawing;

namespace PhasmophobiaHandbook.Structs.Base
{
    public class CursedItem
    {
        public CursedItem(string name, string[] notes, Bitmap image, List<TarotCard> cards = null, List<OujiaQuestion> questions = null)
        {
            Name = name;
            Notes = notes;
            Image = image;
            Cards = cards;
            Questions = questions;
        }

        public string Name { get; protected set; }
        public string[] Notes { get; protected set; }
        public Bitmap Image { get; private set; }
        public List<TarotCard> Cards { get; private set; } // tarot cards
        public List<OujiaQuestion> Questions { get; protected set; } // oujia board
    }

    public class TarotCard
    {
        public TarotCard(string name, Color colour, Bitmap image, string effect, string draw)
        {
            Name = name;
            BurnColour = colour;
            Image = image;
            Effect = effect;
            DrawChance = draw;
        }

        public string Name { get; private set; }
        public Color BurnColour { get; private set; }
        public Bitmap Image { get; private set; }
        public string Effect { get; private set; }
        public string DrawChance { get; private set; }
    }

    public class OujiaQuestion
    {
        public OujiaQuestion(string type, string description, string[] questions, int sanity)
        {
            Type = type;
            Description = description;
            Questions = questions;
            SanityCost = sanity;
        }

        public string Type { get; private set; }
        public string Description { get; private set; }
        public string[] Questions { get; private set; }
        public int SanityCost { get; private set; }
    }
}
