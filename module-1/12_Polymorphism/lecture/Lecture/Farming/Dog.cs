using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
   public class Dog : FarmAnimal // created new class of dog 
    {
        public Dog () : base("Doggo")
        {

        }

        public void WagTail()
        {
            Console.WriteLine("doggo is happy");
        }
        public void Walk()
        {
            Console.WriteLine("doggo is walking");
        }
        public override string MakeSoundOnce()
        {
            return "bork";
        }
    }
}
