using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
   public class Chicken : FarmAnimal
    {
        public Chicken() : base("Chicken")
        {

        }
        public int LayEggs()
        {
            return 13;
        }

        public override string MakeSoundOnce()
        {
            return "bawk";
        }


    }
}
