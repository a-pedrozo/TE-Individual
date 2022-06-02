using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    public class Program
    {
        public static void Main()
        {
            OldMacDonaldSong song = new OldMacDonaldSong();
            song.Sing();

            int choice = 2;// may be 1, 2, or 3

            if (choice == 0)
            {
                // A
            }
            else if (choice == 1)
            {
                // B
            } else
            {
                //C
            }

            switch (choice) // how to properly use switch 
            {
                case 0:
                    //A
                    break;

                case 1:
                    //B
                    break;
                case 2:
                    //C
                    break;

            }
        }


    }
}
