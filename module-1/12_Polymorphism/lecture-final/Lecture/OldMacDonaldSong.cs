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
            Whale moby = new Whale();
            moby.Swim();
            SingAbout(moby);

            // What about multiple animals?
            Console.WriteLine("Singing about many animals in a loop");
            List<FarmAnimal> farm = new List<FarmAnimal>();
            farm.Add(animal); // My horse from line 15
            farm.Add(moby); // My whale from line 19

            Chicken chicken = new Chicken();
            farm.Add(chicken);

            Whale bob = new Whale();
            bob.EatsPuppets = false;
            farm.Add(bob);

            foreach (FarmAnimal critter in farm)
            {
                SingAbout(critter);
            }

            // What about tractors?
            Tractor tractor = new Tractor();
            SingAbout(tractor);

            // If we have time, talk about static
        }

        // Anything passed in to this method must implement ISingable
        private void SingAbout(ISingable animal)
        {
            // We know ISingables have MakeSoundOnce, MakeSoundTwice and Names
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
