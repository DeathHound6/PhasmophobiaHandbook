using System.Drawing;

namespace PhasmophobiaHandbook.Structs.Base
{
    public class Map
    {
        public string Name { get; private set; }
        public Bitmap Image { get; private set; }
        public MapSize Size { get; private set; }

        public Map(string name, Bitmap image, MapSize size)
        {
            Name = name;
            Image = image;
            Size = size;
        }
    }

    public enum MapSize
    {
        Small,
        Medium,
        Large
    }
}
