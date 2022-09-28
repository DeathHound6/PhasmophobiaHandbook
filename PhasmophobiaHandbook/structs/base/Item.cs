using System.Drawing;

namespace PhasmophobiaHandbook.Structs.Base
{
    public class Item
    {
        public string Name { get; private set; }
        public string[] Notes { get; private set; }
        public Bitmap Image { get; private set; }
        public Item(string name, string[] notes, Bitmap image)
        {
            Name = name;
            Notes = notes;
            Image = image;
        }
    }
}
