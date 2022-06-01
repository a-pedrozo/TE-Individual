using System;
using System.Collections.Generic;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public class FarmAnimal : Object , ISingable // implimenting ISingable to Interface, must be explicit to Interface in order to work
    {       
        public FarmAnimal(string name) : base()
        {
            this.Name = name;
        }

        public string Name { get; }

        public virtual string MakeSoundOnce()
        {
            return "";
        }

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
