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
