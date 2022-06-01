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
            moby.ToString();
            Chicken litte = new Chicken(); // creating instance of new object/ farm animal chicken
            Dog dogget = new Dog();
            dogget.WagTail(); // methods made for dog 
            dogget.Walk();

            Whale bobba = new Whale();
            bobba.EatsNoah= false;
            bobba.ToString();
            
            // What about multiple animals?
            Console.WriteLine("Singing about many animals in a loop");
             List<FarmAnimal> farm = new List<FarmAnimal>();
            farm.Add(animal); // my horse from line 15
            farm.Add(moby); // whale from line 19
            farm.Add(litte); // chicken from line 22
            farm.Add(dogget); // dog from line 23
            farm.Add(bobba); // new instance of whale from line 28

            foreach (FarmAnimal livestock in farm)
            {
                SingAbout(livestock); // going through list of farm animal 
            }
            // What about tractors?
            Tractor tractor = new Tractor();
            SingAbout(tractor);


            // If we have time, talk about static
        }
        // anything passed into this method must impliment ISinable 
        private void SingAbout(ISingable animal)
        {
            // we know ISingables have MakeSOundOnce, MakeSounceTwice, and Names
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
