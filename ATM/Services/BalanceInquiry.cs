using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Threading.Thread;
namespace Services
{
    public class BalanceInquiry : Transaction, IBalanceInquiry
    {
        public BalanceInquiry(int userAccountNumber, IScreen atmScreen, IBankDatabase atmBankDatabase)
            : base(userAccountNumber, atmBankDatabase, atmScreen) { }

        public override void Execute()
        {
            IBankDatabase bankDatabase = base.BankDatabase;
            IScreen screen = base.Screen;
            
            decimal availableBalance = bankDatabase.getAvailableBalance(AccountNumber);
            decimal totalBalance = bankDatabase.getTotalBalance(AccountNumber);

            screen.DisplayMessageLine("\nBalance Information:");
            screen.DisplayMessage(" - Available balance: ");
            screen.DisplayDollarAmount(availableBalance);
            screen.DisplayMessage("\n - Total balance:     ");
            screen.DisplayDollarAmount(totalBalance);
            screen.DisplayMessageLine(string.Empty);

            Sleep(5000);
        }
    }
}