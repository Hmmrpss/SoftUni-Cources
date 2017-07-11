namespace _04.Define_Person_Class
{
    using System;
    using System.Collections.Generic;

    public class Define_Person_Class
    {
        public static void Main()
        {
            //set up the person's 4 accounts
            var accounts = new List<BankAccount>()
            {
                new BankAccount { ID = 1, Balance = 65},
                new BankAccount { ID = 2, Balance = 45},
                new BankAccount { ID = 3, Balance = 35},
                new BankAccount { ID = 4, Balance = 25},
            };

            //set valies for the object
            var person = new Person("Ivan", 20, accounts);

            //get the sum of the money in all of his 4 accounts and print it out
            Console.WriteLine(person.GetBalance());
        }
    }
}