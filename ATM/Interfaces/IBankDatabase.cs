namespace Interfaces
{
    public interface IBankDatabase
    {
        bool AuthenticateUser(int userAccountNumber, int userPin);
        void Credit(int userAccountNumber, decimal amount);
        void Debit(int userAccountNumber, decimal amount);
        decimal getAvailableBalance(int userAccountNumber);
        decimal getTotalBalance(int userAccountNumber);
    }
}