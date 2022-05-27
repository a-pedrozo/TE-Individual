using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationLecture
{ // this declares a new class called "Car" this is a template for creating car objects
    public class Car
    {
        //Constructor are special methods thare are called when class is created
        // Constructors have no return type
        // Constructed MUST be named the same as class name
        public Car(int milesDriven) // instance of class must have miles driven in their parenthesis
        {// this code happens ONCE when a car is created 
            // we usually set properties here
            
            this.Color = "Silver";
            this.MilesDriven = milesDriven; // the parameter value we recieved must be defined in properties 
        }

        //PROPERTIES (Data)
                            // get/set are accessers, get calls it outsite of class, set allows it ot be modified 
        public string Color { get; set; } // one way to create properties 
        public int doors { get; set; }
        public int Cylinders { get; set; }
        public int MilesDriven { get; private set; }
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
        // private means ONLY Car can modify it



        // derived property (also called calculated propert)
        // derived properties have NO setter , no set
        // derived properties are calculated based on other values
        // derived properties are calculated as needed

        public int FurlongsDriven
        {
            get
            {
                int furlongs = MilesDriven * 8;

                return furlongs;
            }
        }


        //METHOD    void is the data type that doesn't return value 
        public int Drive(int miles)
        {// color belongs to the car that is this method is running on 
        // miles is the parameter that was passed in this method 
            Console.WriteLine("The " + Color + "car drove " + miles + " miles");

            MilesDriven += miles;

            return MilesDriven;
        }
        
    }
}
