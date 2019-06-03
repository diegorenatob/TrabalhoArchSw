using Interfaces;

namespace Services
{

    public abstract class Transaction : ITransaction
    {
        public int AccountNumber { get; set; }
        public IBankDatabase BankDatabase { get; set; }
        public IScreen Screen { get; set; }



        public Transaction(int userAccountNumber, IBankDatabase atmBankDatabase, IScreen atmScreen)
        {
            this.AccountNumber = userAccountNumber;
            this.BankDatabase = atmBankDatabase;
            this.Screen = atmScreen;
        }

        public abstract void Execute();
    }
}