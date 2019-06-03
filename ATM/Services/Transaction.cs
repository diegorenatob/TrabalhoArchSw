using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{

    public abstract class Transaction : ITransaction
    {
        public int AccountNumber { get; private set; }
        public IBankDatabase BankDatabase { get; private set; }
        public IScreen Screen { get; private set; }



        public Transaction(int userAccountNumber, IBankDatabase atmBankDatabase, IScreen atmScreen)
        {
            this.AccountNumber = userAccountNumber;
            this.BankDatabase = atmBankDatabase;
            this.Screen = atmScreen;
        }

        public abstract void Execute();
    }
}