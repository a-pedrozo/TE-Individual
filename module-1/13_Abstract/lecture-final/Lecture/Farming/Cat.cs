using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    // sealed = nothing can inherit from me
    public sealed class Cat : FarmAnimal
    {
        public Cat() : base("CAT")
        {

        }

        public override string MakeSoundOnce()
        {
            return "MEOOOOWWWW";
        }
    }
}
