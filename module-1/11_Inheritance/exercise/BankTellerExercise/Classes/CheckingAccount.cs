namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
            
        }
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal newBalance = base.Withdraw(amountToWithdraw);
            if (newBalance < 0.0m && newBalance > -100.00m)
            {
                newBalance -= 10.00m;
            }
            return newBalance;


        }

    }
}
