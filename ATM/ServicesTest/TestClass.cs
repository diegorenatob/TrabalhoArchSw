using System;
using Domain;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Persistence;
using Services;
using UI;

namespace ServicesTest
{
    [TestClass]
    public class TestClass
    {
        private const int Account = 12345;
        private readonly Menu _menu;
        private readonly BankDatabase _bankDatabase;
        private readonly Screen _iScreen;
        private readonly Keypad _keypad;
        private readonly CashDispenser _cashDispenser;
        private readonly DepositSlot _depositSlot;

        public TestClass()
        {
            _depositSlot = new DepositSlot();
            _menu= new Menu();
            _bankDatabase=new BankDatabase();
            _iScreen=new Screen();
            _keypad=new Keypad();
            _cashDispenser=new CashDispenser();

        }


        [TestMethod]
        public void Transaction1()
        {
            _menu.CreateTransaction(1, Account, _bankDatabase, _iScreen, _keypad, _cashDispenser, _depositSlot);
        }


        [TestMethod]
        public void Transaction2()
        {
            _menu.CreateTransaction(2, Account, _bankDatabase, _iScreen, _keypad, _cashDispenser, _depositSlot);
            
        }


        [TestMethod]
        public void Transaction3()
        {
            _menu.CreateTransaction(3, Account, _bankDatabase, _iScreen, _keypad, _cashDispenser, _depositSlot);
        }


        [TestMethod]
        public void Transaction4()
        {
            _menu.CreateTransaction(4, Account, _bankDatabase, _iScreen, _keypad, _cashDispenser, _depositSlot);
        }
    }

}
