using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlaireAtm
{
    public partial class AtmDisplay : Form
    {
        private Account activeAccount = null;
        private readonly List<Account> accounts = new List<Account>();

        public AtmDisplay()
        {
            InitializeComponent();
            ActionsContainer.SendToBack();
        }

        public AtmDisplay(List<Account> accounts) : this()
        {
            addAccounts(accounts);
        }

        public void addAccount(Account account)
        {
            this.accounts.Add(account);
        }

        public void addAccounts(List<Account> accounts)
        {
            this.accounts.AddRange(accounts);
        }

        #region Login
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            activeAccount = findAccount();
            if (activeAccount != null)
            {
                AccountNoInput.Text = "";
                PinNoInput.Text = "";
                LoginContainer.SendToBack();
                ActionsContainer.BringToFront();
                displayBalance();
            }
        }

        protected Account findAccount()
        {
            string accountNumber = AccountNoInput.Text;
            string pinNumber = PinNoInput.Text;
            
            foreach (Account account in accounts)
            {
                if (account.AccountNumber.Equals(accountNumber) && account.PinNumber.Equals(pinNumber))
                {
                    return account;
                }
            }
            return null;
        }
        #endregion

        #region Actions
        private void CheckBalance_Click(object sender, EventArgs e)
        {
            displayBalance();
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(MoneyInput.Text);
            bool withdrawn = activeAccount.withdraw(amount);
            if (withdrawn)
            {
                displayBalance();
            }
            else
            {
                MessageBox.Show("Insufficient funds!");
            }
        }

        private void WithdrawThreadSafeBtn_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(MoneyInput.Text);
            bool withdrawn = activeAccount.withdrawThreadSafe(amount);
            if (withdrawn)
            {
                displayBalance();
            }
            else
            {
                MessageBox.Show("Insufficient funds!");
            }
        }

        private void displayBalance()
        {
            balanceDisplay.Text = activeAccount.Balance.ToString();
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            int amount = Int32.Parse(MoneyInput.Text);
            bool deposited = activeAccount.deposit(amount);
            if (deposited)
            {
                displayBalance();
            }
            else
            {
                MessageBox.Show("Could not deposit funds");
            }
        }
        #endregion

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            balanceDisplay.Text = "";
            MoneyInput.Text = "";
            LoginContainer.BringToFront();
            ActionsContainer.SendToBack();
        }
    }
}
