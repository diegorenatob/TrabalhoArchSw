using System;
using Domain;
using Persistence;
using Services;
using UI;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            var atm= new ATM(new CashDispenser(), new BankDatabase(),new DepositSlot(), new Keypad(), new Screen(),new Menu());
            atm.Run();
        }
    }
}
