using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Whale : FarmAnimal
    {
        public Whale() : base("WHAAAAAAAAAALE")
        {
            this.EatsPuppets = true;
        }

        public void Swim()
        {
            Console.WriteLine("Just keep swimming");
        }

        public override string MakeSoundOnce()
        {
            return "I AM POLLLLYMORPHIIIIIICC";
        }

        public bool EatsPuppets { get; set; } = true;

        public override string ToString()
        {
            return "Whale (Eats puppets: " + EatsPuppets + ")";
        }
    }
}
