using NUnit.Framework;
//
using System;
using BankAccount;
namespace BankAccount.Tests
{
    [TestFixture]
    public class AccountSenarios
    {
        /*
         * For my unit tests I wanted to run a few senarios for in for testing my code.
         */

       /*
       Senario 1: Open checking and saving account and transfer money into them then close both accounts.
         */
      [Test]
      public void _senarioOne()
        {
            CheckingAccount checking = new CheckingAccount(0f);
            SavingsAccount savings = new SavingsAccount(0f);
            checking.toAdd(10);
            savings.toAdd(10f);


            Assert.AreEqual(checking.GetCheckingAmount(),10.00);
            Assert.AreEqual(savings.GetSavings(), 0);

            checking.CloseAccount();
            savings.CloseAccount();

            Assert.AreEqual(checking.GetCheckingAmount(), 0);
            Assert.AreEqual(savings.GetSavings(), 0);
        }

        /*
        Senario Two: Open checking and savings and take everything from checking into savings.
         */

        
        /*
        Senario Three: Create business account with no money and have overdraft charge
         */
         
        /*
        Senario Four: Create Checking,Savings account transfer eveything to saving and have overdraft occur.
         */
        
         /*
        Senario Five: 
         */
    }

}

