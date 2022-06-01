namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        public string AccountHolderName { get; set; }

        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; } = 0.0m;

          
                
        public BankAccount( string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            

        }

        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }

       public decimal Deposit(decimal amountToDeposit)
        {
            Balance += amountToDeposit;
            return Balance;
        }

        public virtual decimal Withdraw (decimal amountToWithdraw)
        {
            Balance -= amountToWithdraw;
            return Balance;
        }

        


    }

}



// will need to use private set for classes 
// cannot mannually set balances from child classes 
// two methods will modify balance : amountToDeposit and amountToWithdraw 
// will need to ovverride withdraw method 
// to modify balace will be base.withdraw
// hint will have idea of using constructors of checking and savings account
