using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class RectangleWall : Wall
    {
        public int Length { get; }
        public int Height { get; }

        public RectangleWall(string name, string color, int length, int height) : base(name, color)
        {
            this.Length = length;
            this.Height = height;
                      
        }

        public override int GetArea()
        {
            int area = Length * Height;
            return area;
        }

        public override string ToString()
        {
            return $"{Name} ({Length}x{Height}) rectangle"; 
            
        }
        
    }
}
