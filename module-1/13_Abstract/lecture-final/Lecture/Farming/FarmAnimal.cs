using System;
using System.Collections.Generic;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public abstract class FarmAnimal : ISingable
    {       
        // abstract means I can't say new FarmAnimal(...)

        public FarmAnimal(string name) : base()
        {
            this.Name = name;
        }

        public string Name { get; }

        // abstract means that inheriting classes MUST override it
        public abstract string MakeSoundOnce();
 
        // virtual means that inheriting classes MAY override it
        public virtual string MakeSoundTwice()
        {
            string sound = MakeSoundOnce();
            return sound + " " + sound;
        }

        // TODO: Override ToString
        public override string ToString()
        {

            return Name;
        }
    }
}
