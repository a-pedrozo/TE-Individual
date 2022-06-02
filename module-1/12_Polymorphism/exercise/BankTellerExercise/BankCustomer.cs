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

        private List<IAccountable> accountables = new List<IAccountable>();



        public void AddAccount(IAccountable newAccount)
        {
            foreach (List<IAccountable> accounts in accountables)
            {
                accountables.Add(newAccount);
            }
            
            
        }

        public IAccountable[] GetAccounts()
        {
            return null;
        }

    }
}   // required arrray or like an array possibly list 
    // bank customer is not IAccoutable
    // IsVip is derived property
