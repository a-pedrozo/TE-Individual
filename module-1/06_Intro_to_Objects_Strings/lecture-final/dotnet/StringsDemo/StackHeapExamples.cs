using System;

namespace StringsDemo
{
    public class StackHeapExamples
    {
        public int IncreaseNumber(int number)
        {
            number += 1; // Either number++ or number = number + 1 would also work

            return number;
        }

        public void Drive(HondaCivic car, int milesToDrive)
        {
            car.OdometerMiles += milesToDrive;
        }
    }
}
