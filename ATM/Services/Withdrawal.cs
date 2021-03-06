﻿using Interfaces;
using static System.Console;
using static System.Threading.Thread;
namespace Services
{
    public class Withdrawal : Transaction, IWithdrawal
    {
        private decimal _amount;
        private IKeypad _keypad;
        private ICashDispenser _cashDispenser;

        private const int CANCELED = 6;

        public Withdrawal(int userAccount, IScreen atmScreen,
              IBankDatabase atmBankDatabase, IKeypad atmKeypad, ICashDispenser atmCashDispenser)
            : base(userAccount, atmBankDatabase, atmScreen)
        {
            _keypad = atmKeypad;
            _cashDispenser = atmCashDispenser;
        }

        private int DisplayMenuOfAmounts()
        {
            int userChoice = 0;

            int[] amounts = { 0, 20, 40, 60, 100, 200 };

            while (userChoice == 0)
            {
                Clear();
                Screen.DisplayMessageLine("\nWITHDRAWAL MENU: ");
                Screen.DisplayMessageLine("1 - $20");
                Screen.DisplayMessageLine("2 - $40");
                Screen.DisplayMessageLine("3 - $60");
                Screen.DisplayMessageLine("4 - $100");
                Screen.DisplayMessageLine("5 - $200");
                Screen.DisplayMessageLine("6 - Cancel transaction");
                Screen.DisplayMessage("\nChoose a withdrawal amount: ");

                int input = _keypad.GetInput();

                switch (input)
                {
                    case 1: // if the user chose a withdrawal amount 
                    case 2: // (i.e., chose option 1, 2, 3, 4 or 5), return the
                    case 3: // corresponding amount from amounts array
                    case 4:
                    case 5:
                        userChoice = amounts[input]; // save user's choice
                        break;
                    case CANCELED: // the user chose to cancel
                        userChoice = CANCELED; // save user's choice
                        break;
                    default: // the user did not enter a value from 1-6
                        Screen.DisplayMessageLine("\nInvalid selection. Try again.");
                        Sleep(2000);
                        break;
                }
            }

            return userChoice;
        }

        public override void Execute()
        {
            bool isCashDispensed = false;
            decimal availableBalance;

            IBankDatabase bankDatabase = base.BankDatabase;

            do
            {
                _amount = (decimal)DisplayMenuOfAmounts();

                if (_amount != CANCELED)
                {
                    availableBalance = bankDatabase.getAvailableBalance(AccountNumber);
                    if (_amount <= availableBalance)
                    {
                        if (_cashDispenser.IsSufficiantCashAvailable(_amount))
                        {
                            bankDatabase.Debit(AccountNumber, _amount);
                            _cashDispenser.DispenseCash(_amount);
                            isCashDispensed = true;

                            Screen.DisplayMessageLine("\nYour cash has been dispensed. Please take your cash now.");
                        }
                        else
                            Screen.DisplayMessageLine("\nInsufficient cash available in the ATM.\n\nPlease choose a smaller amount.");
                    }
                    else
                        Screen.DisplayMessage("\nInsufficient funds in your account.\n\nPlease choose a smaller amount.");
                    Sleep(3000);
                }
                else
                {
                    Screen.DisplayMessageLine("\nCancelling transaction...");
                    Sleep(3000);
                    return;
                }
            } while (!isCashDispensed);
        }
    }
}
