namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {


        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw < 150.00m && Balance - amountToWithdraw > 0.0m)
            {
                base.Withdraw(amountToWithdraw + 2.00m);
                return Balance;

            }
            else if (Balance - amountToWithdraw > 150.00m)
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
