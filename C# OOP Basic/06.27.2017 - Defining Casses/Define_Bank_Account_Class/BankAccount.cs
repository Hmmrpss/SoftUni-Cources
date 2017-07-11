namespace Define_Bank_Account_Class
{
    public class BankAccount
    {
        //set up private fields id and balance for the class
        private int id;

        private double balance;

        //define public properties ID and Balance
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
                //return balance
                return this.balance;
            }
            set { this.balance = value; }
        }
    }
}