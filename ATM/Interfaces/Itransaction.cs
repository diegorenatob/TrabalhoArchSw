using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface ITransaction
    {
        int AccountNumber { get; }
        IBankDatabase BankDatabase { get; }
        IScreen Screen { get; }
        void Execute();
    }
}
