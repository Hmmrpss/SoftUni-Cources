namespace _02.Methods
{
    using System;

    public class Methods
    {
        public static void Main()
        {
            //set up a new bank account
            BankAccount account = new BankAccount();

            //set values for it's properties
            account.ID = 1;
            account.Deposit(15);
            account.Withdraw(5);

            //print out the object
            Console.WriteLine(account.ToString());
        }
    }
}