using System;
namespace BankAccount
{
    public class CheckingAccount : Account
    {
       

        public CheckingAccount(float money)
        {
            accountMoney = money;
        }

        private float GetCheckingAmount()
        {
            return accountMoney;
        }
        private void CheckingAdd(float toAdd)
        {
            accountMoney += toAdd;
        }

        //Transfer Money from checking to savings.
        private float TransferChecking(SavingsAccount saving, CheckingAccount checking, float amount)
        {
            
            checking.accountMoney -= amount;
            saving.accountMoney += amount;
            return checking.accountMoney;

        }

    }
}
