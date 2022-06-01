using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : ISingable // impliments ISingalbe Must have all parameters in order for complier to work 
    {
        public string Name { get; } = "john deer";

        public string MakeSoundOnce()
        {
            return "Yeet";
        }

        public string MakeSoundTwice()
        {
            return "yeet-yeet";
        }
    }
}
