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
        public Item(string name, string[] notes, Bitmap image, int price, int limit, bool starter)
        {
            Name = name;
            Notes = notes;
            Image = image;
            Price = price;
            Limit = limit;
            Starter = starter;
        }
    }
}
