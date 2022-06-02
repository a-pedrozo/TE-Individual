using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public sealed class Cat : FarmAnimal   // sealed == nothing can inherit from this class
    {
        public Cat() : base("CAT")
        {

        }

        public override string MakeSoundOnce()
        {
            return "meow";
        }
    }
}
