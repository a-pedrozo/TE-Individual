using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip { get; }



        public void AddAccount(IAccountable newAccount)
        {
            

        }

        public IAccountable GetAccounts()
        {
            return null;
        }

    }
}   // required arrray or like an array possibly list 
    // bank customer is not IAccoutable
