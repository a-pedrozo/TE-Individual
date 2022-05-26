using System;

namespace EncapsulationLecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a Car with a default constructor
            // 3 here is the number of miles driven for the car
            Car batmobile = new Car(3); // calling the constructor

            batmobile.Color = "Black";
            batmobile.ColorOldWay = "Black";
            string oldColor = batmobile.ColorOldWay;

            batmobile.Drive(22);

            // Create another car instance.
            Car johnsCRV = new Car(15418);
            johnsCRV.Color = "Green"; // this uses set
            Console.WriteLine(johnsCRV.Color); // this uses get
            johnsCRV.Drive(10);

            Car vinnyCar = new Car(1000);
            vinnyCar.Drive(2);

            int finalBatMileage = batmobile.Drive(22);

            // Roll back the odometer
            // THIS VIOLATES ENCAPSULATION!
            // batmobile.MilesDriven = 0;

            Console.WriteLine(batmobile.MilesDriven);
            Console.WriteLine(batmobile.FurlongsDriven);

            // Show Fields (briefly)

            // Add properties (data) to the car

            // Add a method

            // Add a constructor parameter and talk about "this"

            // Talk about encapsulation and private properties

            // Make a derived (calculated) property

            // Things for Friday:
            // - Fields / Class Variables
            // - Overloading
            // - Static
            // - Documentation

            // Maybe:
            // - Get-only properties
            // - Readonly
        }
    }
}
