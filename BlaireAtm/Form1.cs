using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BlaireAtm
{
    public partial class Form1 : Form
    {
        private List<Thread> atms = new List<Thread>();
        private List<Account> accounts = new List<Account>();

        public Form1()
        {
            InitializeComponent();

            accounts.Add(new Account(300, "111111", "1111"));
            accounts.Add(new Account(750, "222222", "2222"));
            accounts.Add(new Account(3000, "333333", "3333"));
        }

        private void NewAtmBtn_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(newAtm));
            thread.Start();
            atms.Add(thread);
        }

        private void newAtm()
        {
            Form atmDisplay = new AtmDisplay(accounts);
            atmDisplay.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread thread in atms)
            {
                thread.Abort();
                thread.Join();
            }
        }
    }
}
