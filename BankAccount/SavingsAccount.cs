using System;
namespace BankAccount
{
    public class SavingsAccount: Account
    {
        public new float accountMoney;

        public SavingsAccount(float money)
        {
            accountMoney = money;
        }

        public void CompoundInterest(float percentage)
        {
            accountMoney *= percentage;
        }
        public float GetSavings()
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
            return 0f;
        }
        
    }
}
