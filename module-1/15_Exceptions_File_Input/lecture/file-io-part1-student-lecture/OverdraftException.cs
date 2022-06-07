using System;

namespace FileInputLecture
{
    public class OverdraftException : Exception
    {
        public double OverdraftAmount { get; }

        public OverdraftException(string message, double overdraftAmount) : base(message)
        {
            this.OverdraftAmount = overdraftAmount;
        }
    }

    public class NoDietDoctorPepperEcetion : Exception // created another class inside overdraft exception 
    {
        public NoDietDoctorPepperEcetion(string message)
            : base(message)
        {

        }
    }

}
