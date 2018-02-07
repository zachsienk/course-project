using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        //constructor to initilize x and y
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            /*
            int xDiff = X - x;
            int yDiff = Y - y;

            int xDiffSqrd = xDiff * xDiff;
            int yDiffSqrd = yDiff * yDiff;

            //(int) before math.sqrt changes result to an integer
            return (int)Math.Sqrt(xDiffSqrd + yDiffSqrd);
            */
            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
