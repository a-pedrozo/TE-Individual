namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance) // this is how to call parent constructors 
        {


        }
                

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            
            if ((Balance - amountToWithdraw < 0.00m) && (Balance - amountToWithdraw > -100.00m))
            {

                base.Withdraw(Balance - 10.00m);
                return Balance;
            }
            else if (Balance - amountToWithdraw > 0.00m)
            {
                base.Withdraw(amountToWithdraw);
                return Balance;

            }
            else
            {
                return Balance;
            }
            
            

            

            


        }

    }
}
