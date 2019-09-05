using System;
namespace BankAccount
{
    public class BusinessAccount: Account
    {
        public BusinessAccount(float money)
        {
            accountMoney = money;
        }

        public float BusinessOverdrawn()
        {
            if(CheckOverdraw() == true)
            {
                Console.WriteLine("You have overdrawn your account");
                accountMoney *= 0.5f;
                return accountMoney;
            }
            else
            {
                Console.WriteLine("You have not overdrawn in your Business Account");
                return accountMoney; 
            }
            
        }
    }
}
