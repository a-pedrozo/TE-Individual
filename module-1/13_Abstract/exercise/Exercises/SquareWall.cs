using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class SquareWall : RectangleWall
    {
        public SquareWall(string name, string color, int sideLength) : base(name, color)
        {
           // this.SideLength = sideLength;
        }

        public override string ToString()
        {
            return null;// return $"{Name} ({sideLength}x{sideLength}) square";
        }
    }
}
