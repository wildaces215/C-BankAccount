using System;

namespace BankAccount
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            CheckingAccount checking = new CheckingAccount(45.99f);
            SavingsAccount savings = new SavingsAccount(0.00f);

            

        }
    }
}
