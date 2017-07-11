using System;
using System.Collections.Generic;

namespace _03.Test_Client
{
    public class Test_Client
    {
        public static void Main()
        {

            //set up  dict for the existing accounts
            var accounts = new Dictionary<int, BankAccount>();
            string input = string.Empty;

            //read commands until "End"
            while ((input = Console.ReadLine()) != "End")
            {
                //get the elements of the commands
                var tokens = input.Split();
                var command = tokens[0];

                //set up a switch for the commands and give them the input parameters and the accounts dict
                switch (command)
                {
                    case "Create":
                        Create(tokens, accounts);
                        break;
                    case "Deposit":
                        Deposit(tokens, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(tokens, accounts);
                        break;
                    case "Print":
                        Print(tokens, accounts);
                        break;
                }
            }
        }

        //Create an account
        private static void Create(string[] args, Dictionary<int, BankAccount> accounts)
        {
            //get the account id
            var id = int.Parse(args[1]);

            //check if there is an existing account with this id
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            //if there isn't one
            else
            {
                //create it
                var account = new BankAccount();
                //and set it's params
                account.ID = id;
                //and add it to the dict
                accounts.Add(id, account);
            }
        }

        //Deposit a sum in the bank account
        private static void Deposit(string[] args, Dictionary<int, BankAccount> accounts)
        {
            //get the account id and the sum of money to deposit
            var id = int.Parse(args[1]);
            var amount = double.Parse(args[2]);

            //check if the account exists
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            //if it does
            else
            {
                //deposit the money
                accounts[id].Deposit(amount);
            }
        }

        //Withdraw a sum from the bank account
        private static void Withdraw(string[] args, Dictionary<int, BankAccount> accounts)
        {
            //get the account id and the sum of money to withdraw
            var id = int.Parse(args[1]);
            var amount = double.Parse(args[2]);

            //check if the account exists
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            //check if there are enough money in it
            else if (accounts[id].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            //if there are
            else
            {
                //withdraw the money
                accounts[id].Withdraw(amount);
            }
        }

        //print out the account data
        private static void Print(string[] args, Dictionary<int, BankAccount> accounts)
        {
            //get the account id
            var id = int.Parse(args[1]);

            //check if it exists
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            //if it does - print it out
            else
            {
                Console.WriteLine(accounts[id]);
            }
        }
    }
}