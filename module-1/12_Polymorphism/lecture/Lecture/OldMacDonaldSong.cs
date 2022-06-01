using Lecture.Farming;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture
{
    public class OldMacDonaldSong // One of the sillier classes you will ever see
    {
        public void Sing()
        {
            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");

            // Let's try singing about a Farm Animal
            FarmAnimal animal = new Horse();
            SingAbout(animal);

            // Let's try a different animal

            // What about multiple animals?

            // What about tractors?

            // If we have time, talk about static
        }

        private void SingAbout(FarmAnimal animal)
        {
            string soundOnce = animal.MakeSoundOnce();
            string soundTwice = animal.MakeSoundTwice();

            Console.WriteLine($"And on his farm there was a {animal.Name} ee ay ee ay oh");
            Console.WriteLine($"With a {soundTwice} here and a {soundTwice} there");
            Console.WriteLine($"Here a {soundOnce}, there a {soundOnce} everywhere a {soundTwice}");
            Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
            Console.WriteLine();
        }
    }
}
