using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankCustomer : IAccountable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip { get; }
       

        public decimal Balance
        {
            get
            {
                decimal Balance = this.Balance;
                return Balance;
            }
        }

        List<IAccountable> accountables = new List<IAccountable>();

        public void AddAccount(IAccountable newAccount)
        {
         
            accountables.Add(newAccount);
            
        }

        public IAccountable[] GetAccounts() // if statemnts for vip 
        {

            return accountables.ToArray();
        }


    }
}
