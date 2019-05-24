namespace Interfaces
{
    public interface IAccount
    {
        int AccountNumber { get; }
        decimal AvailableBalance { get; }
        decimal TotalBalance { get; }

        void Credit(decimal amount);
        void Debit(decimal amount);
        bool ValidatePin(int userPin);
    }
}