using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileInputLecture.FileReading
{
    public class Part2_FileReading
    {
        public void CensorAliceAndWonderland()
        {
            string filePath = @"C:\users\student\alice.txt"; // Note: @ is a verbatim string and converts \ into actual \ characters

            Console.WriteLine();
            Console.WriteLine($"Displaying the censored contents of {filePath}");

            // Feel free to tweak these to your enjoyment
            const string wordToCensor = "Cat";
            const string replacementWord = "Doggo";

            /* USING STATEMENTS
             * 
             * A using statement opens a resource that implements IDisposable and makes sure it is closed when
             * the scope completes - even if an Exception was encountered
             */
            int lineNumber = 0;
            try
            {
                // Add a using statement that creates a StreamReader pointing at the correct file
                using (StreamReader reader = new StreamReader(filePath)) // StreamReader opens the file for reading 
                {
                    // While we haven't reached the end of the file...
                    while (!reader.EndOfStream)
                    {
                        // Read in the next line from the file
                        string line = reader.ReadLine();

                        lineNumber++;


                        // If the line needs censoring,
                        if (line.Contains(wordToCensor))
                        {
                            line = line.Replace(wordToCensor, replacementWord);
                            // Print the censored line to the Console
                            Console.WriteLine(line);
                        }
                    }

                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("could not find file" + filePath);
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Done Censoring");

            // TODO: What happens if the file doesn't exist or we don't have permissions?

            // TODO: Can we handle generic exceptions and more specific exceptions in the same try / catch?
        }

        public void ExploreDirectories()
        {
            // Let's take a look at DirectoryInfo and Environment
            DirectoryInfo info = new DirectoryInfo("C:\\Users");
            FileInfo file = new FileInfo("C:\\users\\studnet\\alice.txt");
            string currentDir = Environment.CurrentDirectory;
            string myFilePath = Path.Combine(currentDir, "MyFile.txt");


            // Let's take a look at Path

            // Let's take a look at FileInfo
        }
    }
}
