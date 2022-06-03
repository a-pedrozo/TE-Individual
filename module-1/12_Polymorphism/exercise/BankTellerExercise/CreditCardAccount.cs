using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
   public class CreditCardAccount : IAccountable
    {
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }
        public decimal Debt { get; private set; } = 0;

        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;

        }

        public decimal Balance                                  
        {
            get
            {
                decimal Balance = -Debt;
                return Balance;
            }
        }

        public decimal Pay(decimal amountToPay)
        {
            Debt -= amountToPay;
            return Balance;
        }
        public decimal Charge(decimal amountToCharge)
        {
            Debt += amountToCharge;
            return Balance;
        }
    }
}
