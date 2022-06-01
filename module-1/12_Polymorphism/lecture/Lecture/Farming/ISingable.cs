using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public interface ISingable // this is an interface 
    {
        // anything claiming to be ISingable must have a MakeSoinceOnce method that retunrs a string and takes in no parameters
        string MakeSoundOnce();

        string MakeSoundTwice();

        //anything claiming to be ISingable must have a public Name property of type string that has a getter
        string Name { get; }
    }
}
