using NUnit.Framework;
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
       Senario 1: Open checking and saving account and transfer money into them.
         */
      [Test]
      public void senarioOne()
        {
            CheckingAccount checking = new CheckingAccount(0f);
            SavingsAccount savings = new SavingsAccount(0f);
            checking.toAdd(10);
            savings.toAdd(10f);



        }

        /*
        Senario Two: Open checking and savings and take everything from checking into savings.
         */
        [Test]
        public void senarioTwo()
        {

        }
    }

}

