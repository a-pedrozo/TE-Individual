using System;

namespace StringsDemo
{
    // HondaCivic is a class. It is a template for creating instances of itself. For example, Matt's car and John's car.
    public class HondaCivic
    {
        // This is a property. Think about this as some public data associated with an instance of the class
        public int OdometerMiles { get; set; } 

        // This is a method. A method like this one belongs to each instance of the class, but works with its data
        public void HonkHorn()
        {
            Console.WriteLine("Beep beep! I have " + OdometerMiles + " miles on my odometer!");

            // If you're daring, you can uncomment the next line AFTER lecture
            // Console.Beep();
        }
    }
}
