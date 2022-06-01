using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Whale :FarmAnimal
    {
        public Whale() : base ("Whale")
        {

        }

        public void Swim()
        {
            Console.WriteLine("Just keep swimming");

        }
        public override string MakeSoundOnce()
        {
            return "Not a cow";
        }

        public bool EatsNoah { get; set; } = true;

        public override string ToString()
        {
            return "Whale (eats puppets:" + EatsNoah + ")";
        }
    }
}
