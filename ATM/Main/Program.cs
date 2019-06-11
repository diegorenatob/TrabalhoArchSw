using System;
using Domain;
using Persistence;
using Services;
using UI;
using ATM = UI.ATM;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var atm= new ATM(new CashDispenser(), new BankDatabase(),new DepositSlot(), new Keypad(), new Screen(),new Menu());
            atm.Run();
        }
    }
}
