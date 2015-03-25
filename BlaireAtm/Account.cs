using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BlaireAtm
{
    public class Account
    {
        private readonly object withdrawLockObject = new object();

        public Account(int balance, string account, string pin)
        {
            this.Balance = balance;
            this.AccountNumber = account;
            this.PinNumber = pin;
        }

        public bool withdrawThreadSafe(int amount)
        {
            lock (withdrawLockObject)
            {
                return withdraw(amount);
            }
        }

        public bool withdraw(int amount)
        {
            if (canWithdraw(amount))
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool canWithdraw(int amount)
        {
            bool canWithdraw = Balance >= amount;
            Thread.Sleep(15000);
            return canWithdraw;

        }

        public bool deposit(int amount)
        {
            Balance += amount;
            return true;
        }

        public int Balance { get; private set; }
        public string AccountNumber { get; private set; }
        public string PinNumber { get; private set; }
    }
}
