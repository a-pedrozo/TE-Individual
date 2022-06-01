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
            // Declare things that live on our farm
            FarmAnimal mrEd = new Horse();
            Whale moby = new Whale();
            Chicken chicken = new Chicken();

            Whale bob = new Whale();
            bob.EatsPuppets = false;

            Tractor tractor = new Tractor();

            // Put everything in our farm in a list
            List<ISingable> farm = new List<ISingable>();
            farm.Add(mrEd);
            farm.Add(moby);
            farm.Add(chicken);
            farm.Add(bob);
            farm.Add(tractor);

            // Sing about our farm
            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");

            foreach (ISingable thing in farm)
            {
                SingAbout(thing);
            }

            // If we have time, talk about static
        }

        // Anything passed in to this method must implement ISingable
        private void SingAbout(ISingable thing)
        {
            // We know ISingables have MakeSoundOnce, MakeSoundTwice and Names
            string soundOnce = thing.MakeSoundOnce();
            string soundTwice = thing.MakeSoundTwice();

            Console.WriteLine($"And on his farm there was a {thing.Name} ee ay ee ay oh");
            Console.WriteLine($"With a {soundTwice} here and a {soundTwice} there");
            Console.WriteLine($"Here a {soundOnce}, there a {soundOnce} everywhere a {soundTwice}");
            Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
            Console.WriteLine();
        }

    }
}
