namespace Define_Bank_Account_Class
{
    using System;

    public class Define_Bank_Account_Class
    {
        public static void Main()
        {
            //set up a new bank account
            BankAccount account = new BankAccount();

            //set values for it's properties
            account.ID = 1;
            account.Balance = 15;

            //print out the object
            Console.WriteLine($"Account {account.ID}, balance {account.Balance}");
        }
    }
}