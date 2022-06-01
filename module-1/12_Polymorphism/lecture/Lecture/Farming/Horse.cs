using System;
using System.Collections.Generic;

namespace Lecture.Farming
{
    public class Horse : FarmAnimal
    {
        public Horse() : base("HORSE")
        {
        }

        public override string MakeSoundOnce()
        {
            return "NEIGH";
        }

        public void Gallup()
        {
            // Note: Galluping will be implemented in a future release
        }
    }
}
