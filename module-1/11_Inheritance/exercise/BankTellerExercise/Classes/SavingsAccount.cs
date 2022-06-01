namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount()
        {
            //??

        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw < 150.00m)
            {
            return base.Withdraw(amountToWithdraw + 2.00m);

            }
            else if (amountToWithdraw > base.Withdraw(amountToWithdraw))
            {
                return base.Withdraw(Balance);
            }
            else
            {
                return base.Withdraw(Balance);
            }
        }


    }
}
