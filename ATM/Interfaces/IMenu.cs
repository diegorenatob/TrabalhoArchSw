namespace Interfaces
{
    public interface IMenu
    {
        ITransaction CreateTransaction(int type, int currentAccountNumber, IBankDatabase atmBankDatabase, IScreen atmScreen, IKeypad atmKeypad, ICashDispenser atmCashDispenser, IDepositSlot atmDepositSlot);
    }
}