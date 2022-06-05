using System;
using System.Collections.Generic;
using System.Text;

namespace FileInputLecture
{
    public sealed class Account
    {
        public Account(double startingBalance)
        {
            this.Balance = startingBalance;
        }

        public double Balance { get; private set; }

        public double Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException("amount", amount, "Amount to withdraw must be above zero");
            }

            double finalBalance = Balance - amount;

            if (finalBalance < 0)
            {
                throw new OverdraftException("You cannot overdraft this account", finalBalance);
            }
            else
            {
                Balance = finalBalance;

                return Balance;
            }
        }

    }
}
