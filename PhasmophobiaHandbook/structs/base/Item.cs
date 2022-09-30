using System.Collections.Generic;
using System.Drawing;

namespace PhasmophobiaHandbook.Structs.Base
{
    public class Item
    {
        public string Name { get; private set; }
        public string[] Notes { get; private set; }
        public Bitmap Image { get; private set; }
        public int Price { get; private set; }
        public int Limit { get; private set; }
        public bool Starter { get; private set; }
        public List<SpiritBoxQuestion> SpiritBoxQuestions { get; private set; }
        public Item(string name, string[] notes, Bitmap image, int price, int limit, bool starter, List<SpiritBoxQuestion> spiritBoxQuestions = null)
        {
            Name = name;
            Notes = notes;
            Image = image;
            Price = price;
            Limit = limit;
            Starter = starter;
            SpiritBoxQuestions = spiritBoxQuestions;
        }
    }

    public class SpiritBoxQuestion
    {
        public string Type { get; private set; }
        public string[] Questions { get; private set; }
        public SpiritBoxQuestion(string type, string[] questions)
        {
            Type = type;
            Questions = questions;
        }
    }
}
