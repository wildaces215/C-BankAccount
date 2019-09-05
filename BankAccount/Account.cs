using System;
namespace BankAccount
{
    public abstract class Account
    {
        public float accountMoney;
        //Transfer from checking to Savings
       
        //Close Account
        public void CloseAccount()
        {
            accountMoney = 0;
        }
       public void toAdd(float toAdd)
        {
            accountMoney += toAdd; 
        }

        //Create overdraw function and if business account make it more steep.
        public bool CheckOverdraw()
        {
            if(accountMoney >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
    
        }


    }
}
