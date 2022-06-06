using System;

namespace FileInputLecture
{
    public class OverdraftException : Exception
    {
        public double OverdraftAmount { get; }

        public OverdraftException(string message, double overdraftAmount) 
            : base(message)
        {
            this.OverdraftAmount = overdraftAmount;
        }
    }

    public class NoDietDoctorPepperException : Exception
    {
        public NoDietDoctorPepperException(string message)
            : base(message)
        {

        }
    }
}
