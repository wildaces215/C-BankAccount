using System;
namespace BankAccount
{
    public class SavingsAccount: Account
    {
        public SavingsAccount(float money)
        {
            accountMoney = money;
        }

        public void CompoundInterest(float percentage)
        {
            accountMoney *= percentage;
        }
        private float GetSavings()
        {
            return accountMoney;
        }

        private float TrasnferChecking(SavingsAccount saving, CheckingAccount checking, float amount) {

            saving.accountMoney -= amount;
            checking.accountMoney += amount;

            return saving.accountMoney;
        }

        private float OverDraftCharge()
        {
            if(CheckOverdraw() == true)
            {

            }
        }
        
    }
}
