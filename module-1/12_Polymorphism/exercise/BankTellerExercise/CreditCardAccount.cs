using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CreditCardAccount : IAccountable
    {
        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            
        }
        public string AccountHolderName { get; private set; }
        public string AccountNumber { get; }
        public decimal Debt { get; private set; }

        public decimal Balance
        {
            get
            {
                decimal debt = Balance - Debt;
                return debt;
            }
        }



        public decimal Pay(decimal amountToPay)
        {
            Debt -= amountToPay;
            return Debt;
        }

        public decimal Charge(decimal amountToCharge)
        {
            Debt += amountToCharge;
            return Debt;
        }


    }
}
// there is relationship with debt and balance, balance = negative debt, derived property 
