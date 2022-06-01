using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public interface ISingable
    {
        // Anything claiming to be ISingable
        // must have a MakeSoundOnce method
        // that returns a string
        // and takes in no parameters
        string MakeSoundOnce();

        string MakeSoundTwice();

        // Anything claiming to be ISingable
        // must have a public Name property
        // of type string that has a getter
        string Name { get; }
    }
}
