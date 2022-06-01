using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : ISingable
    {
        public string Name { get; } = "John Deere";

        public string MakeSoundOnce()
        {
            return  "Yeee-haw!";
        }

        public string MakeSoundTwice()
        {
            return "VROOM VROOM!";
        }
    }
}
