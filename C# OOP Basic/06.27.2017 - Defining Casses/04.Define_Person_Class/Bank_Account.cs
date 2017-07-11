namespace _04.Define_Person_Class
{
    public class BankAccount
    {
        //set up private fields id and balance for the class
        private int id;
        private double balance;

        //define public properties ID, Balance, Deposit and Withdraw
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        //overriding method ToString()
        public override string ToString()
        {
            return $"Account ID{ID}, balance {Balance:F2}";
        }
    }
}