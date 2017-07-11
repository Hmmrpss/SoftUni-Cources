namespace _03.Test_Client
{
    public class BankAccount
    {
        //set up private fields id and balance for the class
        private int id;

        private double balance;

        //define public properties ID, Balance, Deposit and Withdraw
        public int ID
        {
            get
            {
                //return id;
                return this.id;
            }
            set
            {
                //id = value;
                this.id = value;
            }
        }

        public double Balance
        {
            get
            {
                //return balance;
                return this.balance;
            }
            set { this.balance = value; }
        }


        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }

        //overriding method ToString()
        public override string ToString()
        {
            return $"Account ID {this.ID}, balance {this.Balance:F2}";
        }
    }
}