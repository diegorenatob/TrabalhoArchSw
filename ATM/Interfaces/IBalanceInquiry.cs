namespace Interfaces
{
    public interface IBalanceInquiry
    {
        void Execute();
        void SetValues(int userAccountNumber, IBankDatabase atmBankDatabase, IScreen atmScreen);
    }
}