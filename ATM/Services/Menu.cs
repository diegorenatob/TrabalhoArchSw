using Interfaces;

namespace Services
{
    public class Menu :  Interfaces.IMenu
    {
        public Menu()
        {
            
        }

        public ITransaction CreateTransaction(int type, int currentAccountNumber, IBankDatabase atmBankDatabase, IScreen atmScreen, IKeypad atmKeypad, ICashDispenser atmCashDispenser, IDepositSlot atmDepositSlot)
        {
            ITransaction temp = null;

            switch (type)
            {
                case 1:
                    temp = new BalanceInquiry(currentAccountNumber, atmScreen, atmBankDatabase);
                    break;
                case 2:
                    temp = new Withdrawal(currentAccountNumber, atmScreen, atmBankDatabase, atmKeypad, atmCashDispenser);
                    break;
                case 3:
                    temp = new Deposit(currentAccountNumber, atmScreen, atmBankDatabase, atmKeypad, atmDepositSlot);
                    break;
            }

            return temp;
        }
    }
}
