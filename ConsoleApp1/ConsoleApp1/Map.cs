using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Map
    {
        //public is an access modifier
        //instance variables
        public readonly int Height;
        public readonly int Width;

        //constructor that passes in height and width
        public Map(int width, int height) {
            Width = width;
            Height = height;
        }

        
        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X < Width
                   && point.Y >= 0 && point.Y < Height;
        }
    }
}
