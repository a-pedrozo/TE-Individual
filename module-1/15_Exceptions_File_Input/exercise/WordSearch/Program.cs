using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args) 
        {

            //1. Ask the user for the file path
            try
            {

                Console.WriteLine("Please enter file path to search for");
                string filePath = Console.ReadLine();

                //2. Ask the user for the search string
                Console.WriteLine("Please type in word to search");
                string searchWord = Console.ReadLine();
                Console.WriteLine("Is this word case sensitive?  Y/N");
                string isCaseSensitive = Console.ReadLine();

                // isCaseSensitive.ToLower();
                if (isCaseSensitive.Equals("y") || isCaseSensitive.Equals("Y"))
                {
                    int lineNumber = 0;
                    using (StreamReader fileInput = new StreamReader(filePath))
                    {
                        while (!fileInput.EndOfStream)
                        {
                            // Read in the next line from the file
                            string line = fileInput.ReadLine();

                            lineNumber++;

                            if (line.Contains(searchWord))
                            {
                                Console.WriteLine(lineNumber + ":" + line);
                            }

                            //alices_adventures_in_wonderland.txt

                        }
                    }
                }
                else if (isCaseSensitive.Equals("N") || isCaseSensitive.Equals("n"))
                {
                    int lineNumber = 0;
                    using (StreamReader fileInput = new StreamReader(filePath))
                    {
                        while (!fileInput.EndOfStream)
                        {
                            // Read in the next line from the file
                            string line = fileInput.ReadLine();
                            string line2 = line;
                            line2.ToLower();

                            lineNumber++;

                            if (line2.Contains(searchWord.ToLower()))
                            {
                                Console.WriteLine(lineNumber + ":" + line);
                            }

                        }
                    }
                }
                else
                {
                    Console.WriteLine("input not valid, select Y/N");
                    
                }

                //3. Open the file

                //4. Loop through each line in the file

            }
            catch (InvalidDataException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //5. If the line contains the search string, print it out along with its line number
        }
    }
}
