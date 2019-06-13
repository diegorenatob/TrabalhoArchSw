using Domain;
using Persistence;
using Services;
using UI;
using ATM = UI.ATM;

namespace Main
{
    class Program
    {
        private static CashDispenser cashDispenser;
        private static  BankDatabase bankDatabase;
        private static DepositSlot depositSlot;
        private static Keypad keypad;
        private static Screen screen;
        private static Menu menu;
        private static ATM atm;



        static void Main(string[] args)
        {
            cashDispenser=new CashDispenser();
            bankDatabase=new BankDatabase();
            depositSlot= new DepositSlot();
            keypad =new Keypad();
            screen =new Screen();
            menu=new Menu();
        
            atm = new ATM(cashDispenser, bankDatabase,depositSlot,keypad, screen,menu);
            atm.Run();
        }
    }
}
