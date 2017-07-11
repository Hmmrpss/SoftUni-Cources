namespace _04.Define_Person_Class
{
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        //set up private fields for the person's name, age and accounts
        private string name;
        private int age;
        private List<BankAccount> accounts;

        //set up the class constructor with 2 params
        public Person(string name, int age)
            : this(name, age, new List<BankAccount>())
        {
        }

        //set up the class constructor with tree params
        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        //set up the public properties Name and Age
       public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //create method for getting the sum of theperson's accounts
        public double GetBalance()
        {
            return this.accounts.Sum(account => account.Balance);
        }
    }
}