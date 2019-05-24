namespace Interfaces
{
    public interface ICashDispenser
    {
        void DispenseCash(decimal amount);
        bool IsSufficiantCashAvailable(decimal amount);
    }
}