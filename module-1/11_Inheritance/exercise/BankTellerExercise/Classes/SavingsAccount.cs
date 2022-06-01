namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {


        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw < 150.00m)
            {
                base.Withdraw(amountToWithdraw - 2.00m);
                return Balance;

            }
            if (Balance > amountToWithdraw)
            {
                return Balance;
            }
            return Balance;
        }


    }
}
