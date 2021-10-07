using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOP_Lab5_working_
{
    public class Account
    {
        private int accNumber;
        private double balance;
        private string owner;

        public Account(int accNumber, double balance, string owner)
        {
            this.accNumber = accNumber;
            this.balance = balance;
            this.owner = owner;
        }

        public int getAccNumber() { return accNumber; }
        public double getBalance() { return balance; }
        public string getOwner() { return owner; }
        public override string ToString()
        {
            return " Account#: " + accNumber + " \tBalance: $" + balance + " \tOwner: " + owner;
        }
    }
}
