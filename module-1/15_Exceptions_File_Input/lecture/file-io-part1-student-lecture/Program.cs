using FileInputLecture.FileReading;
using System;
using System.IO;

namespace FileInputLecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // EXCEPTION HANDLING LECTURE
            Part1_Exceptions lecture1 = new Part1_Exceptions();

            //lecture1.CauseIndexOutOfRangeException();
            // lecture1.CauseDivisionByZeroException();
            lecture1.CauseNullReferenceException();
            lecture1.CauseFormatException();
            // lecture1.CallAnotherMethodThatThrowsAnException();



            // FILE READING LECTURE
            Part2_FileReading lecture2 = new Part2_FileReading();

            // lecture2.CensorAliceAndWonderland();
            // lecture2.ExploreDirectories();



            // Allow the user to press a key before the program ends
            Console.ReadLine();
        }

    }
}
