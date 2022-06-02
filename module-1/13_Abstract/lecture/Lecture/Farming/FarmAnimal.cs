using System;
using System.Collections.Generic;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public abstract class FarmAnimal : object, ISingable
        // abstract means i cant say new FarmAnimal(..)
    {       
        public FarmAnimal(string name) : base()
        {
            this.Name = name;
        }

        public string Name { get; }
        // abstract means that inhertiing classes MUST override it 
        public abstract string MakeSoundOnce();
      

        public string MakeSoundTwice()
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
