using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FizzWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            try
            {

                Console.WriteLine("please enter directory for file to be created");// string directorty = Environment.CurrentDirectory; 
                string filePath = Console.ReadLine();
               
                                
                using (StreamWriter writer = new StreamWriter(filePath))   
                {
                    
                   
                    for (int i = 1; i <= 300; i++)
                    {
                        
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            writer.WriteLine("FizzBuzz");
                        }
                        else if (i % 3 == 0)
                        {
                           writer.WriteLine("Fizz");
                        }
                        else if (i % 5 == 0)
                        {
                            writer.WriteLine("Buzz");
                        }
                        else
                        {
                            writer.WriteLine(i);
                        }
                        
                    }


                }


            } catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(InvalidDataException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
