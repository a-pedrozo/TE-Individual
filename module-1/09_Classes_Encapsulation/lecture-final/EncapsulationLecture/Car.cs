using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture
{
    // This declares a new class called "Car" that is a template
    // for creating car objects
    public class Car
    {
        // CONSTRUCTOR

        // Constructors are special methods that are called
        // when the class is created.
        // Constructors have NO return type
        // Constructors MUST be named the same as the class name
        public Car(int milesDriven)
        {
            // This code happens ONCE when a car is created
            // We usually set properties here

            this.Color = "Silver";
            // the parameter value we received
            this.MilesDriven = milesDriven; 
        }

        // PROPERTIES (data)

        public string Color { get; set; }

        private string colorOldWay;
        public string ColorOldWay
        {
            get
            {
                return colorOldWay;
            }
            set
            {
                colorOldWay = value;
            }
        }

        // Private means ONLY Car can modify it
        public int MilesDriven { get; private set; }

        public int EngineTemperatureF { get; set; }

        // Derived Property (also called calculated property)
        // Derived properties Have NO setter
        // Derived properties are calculated based on other values
        // Derived properties are calculated as needed
        public int FurlongsDriven
        {
            get
            {
                int furlongs = MilesDriven * 8;

                return furlongs;
            }
        }

        // METHOD

        public int Drive(int miles)
        {
            // Color belongs to the car that this method is running on
            // miles is the parameter that was passed in to this method
            Console.WriteLine("The " + Color + " car drove " + miles + " miles");

            MilesDriven += miles;

            return MilesDriven;
        }
    }
}
