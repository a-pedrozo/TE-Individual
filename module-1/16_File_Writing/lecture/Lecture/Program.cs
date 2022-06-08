using System;
using System.IO;
using Lecture.Aids;

namespace Lecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // PART 1 - Writing to a File
            string directorty = Environment.CurrentDirectory; // gets current directory that application is in 
            string filePath = Path.Combine(directorty, "output.txt"); // adding new path to directory 
            Console.WriteLine("writting to " + filePath);

            bool shouldAppendToFile = true; // appending to file keeps current context and adds onto file 
            using (StreamWriter writer = new StreamWriter(filePath, shouldAppendToFile))   // creates new file to write to given path, overrides context by defualt 
            {
                writer.WriteLine("matt made us take an assesment");
                writer.WriteLine("it was about parks");
                writer.WriteLine("this park should be shut down");
                for (int i = 1; i <= 5; i++)
                {
                    writer.WriteLine(i);
                }




            }

            // PART 2 - Reading and Writing

            //  Loop through the contents of Hamlet and display each line on the screen
            string inputFile = Path.Combine(Environment.CurrentDirectory, "hamlet.txt"); // combines current directory with the hamlet txt file
            string outputFile = Path.Combine(Environment.CurrentDirectory, "hamletdotnet.txt"); // new hamlet file to write into 
            
            try
            {
                using (StreamReader reader = new StreamReader(inputFile))
                {
                    using (StreamWriter writer = new StreamWriter(outputFile, false)) // this is writing as its reading file 
                    {


                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();

                            line = line.Replace("HORATIO", "JOHNO");
                            line = line.Replace("MARCELLUS", "MATTICUS");
                            line = line.Replace("BERNARDO", "CORNHOLIO");
                            line = line.Replace("FRANCISCO", "VINNEY");

                            Console.WriteLine(line);
                        }
                    }
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //  Write out the modified contents of Hamlet to a separate file

            // PART 3 - Other Examples - Particularly #4 and #9

            Console.Write("Press enter to finish");
            Console.ReadLine();
        }
    }
}
