using System;
namespace BankAccount
{
    public class CheckingAccount : Account
    {
       

        public CheckingAccount(float money)
        {
            accountMoney = money;
        }

        public float GetCheckingAmount()
        {
            return accountMoney;
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
