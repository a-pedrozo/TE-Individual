using System; // namespace contains console.writeline, namespace is like a folder

namespace EncapsulationLecture // classes should be public for techelevator
{
    public class Program
    {
        public static void Main(string[] args) // classes should be PascalCase 
        {
            // Create a Car with a default constructor
            // 3 is the number of miles driven
            Car batmobile = new Car(3);// instance of car, object 
            Car johnsCRV = new Car(154198);

            batmobile.Color = "Black";
            johnsCRV.Color = "Green";
            Car vinnyCar = new Car(1000);
            // Show Fields (briefly)

            // Add properties (data) to the car
            batmobile.doors = 2;
            batmobile.Cylinders = 12;
            johnsCRV.doors= 4;
            johnsCRV.Cylinders = 4;
            // Add a method
            batmobile.Drive(22);

            vinnyCar.Drive(12345);
            johnsCRV.Drive(98654);

            Console.WriteLine(batmobile.MilesDriven);

            Console.WriteLine(batmobile.FurlongsDriven);



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
