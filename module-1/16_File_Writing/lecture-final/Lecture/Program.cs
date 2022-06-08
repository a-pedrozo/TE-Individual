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
            string directory = Environment.CurrentDirectory;
            string filePath = Path.Combine(directory, "output.txt");
            Console.WriteLine("Writing to " + filePath);

            bool shouldAppendToFile = false;

            using (StreamWriter writer = new StreamWriter(filePath, shouldAppendToFile))
            {
                writer.WriteLine("Matt made us take an assement!");
                writer.WriteLine("It was about amusement parks");
                writer.WriteLine("This amusement park should be shut down");

                for (int i = 0; i < 5; i++)
                {
                    writer.WriteLine(i + 1);
                }
            }

            // PART 2 - Reading and Writing

            //  Loop through the contents of Hamlet and display each line on the screen
            string inputFile = Path.Combine(Environment.CurrentDirectory, "hamlet.txt");
            string outputFile = Path.Combine(Environment.CurrentDirectory, "hamletdotnet.txt");

            try
            {
                // 0
                using (StreamReader reader = new StreamReader(inputFile))
                {
                    using (StreamWriter writer = new StreamWriter(outputFile, false))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();

                            line = line.Replace("HORATIO", "JOHNO");
                            line = line.Replace("MARCELLUS", "MATTICUS");
                            line = line.Replace("BERNARDO", "JIMMICUS");
                            line = line.Replace("FRANCISCO", "VINNICUS");

                            // 2
                            writer.WriteLine(line);
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
            PerformanceDemo.SlowPerformance();
            PerformanceDemo.FastPerformance();

            Console.Write("Press enter to finish");
            Console.ReadLine();
        }
    }
}
