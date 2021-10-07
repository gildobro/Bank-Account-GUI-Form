using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedOOP_Lab5_working_
{
    public partial class Form1 : Form
    {
        AccountManager am;
        public Form1()
        {
            am = new AccountManager();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            int accNum = Convert.ToInt32(txtAccountNumber.Text);
            double balance = Convert.ToDouble(txtBalance.Text);
            am.addAccount(accNum, balance, txtOwner.Text);
            lblNumAccounts.Text = "Total Accounts: " + am.getNumAccounts();
            txtAccountNumber.Text = "";
            txtBalance.Text = "";
            txtOwner.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblSearchBalance.Text = "";
            lblSearchOwner.Text = "";
            int accNum = Convert.ToInt32(txtAccNumSearch.Text);
            Account result = am.findAccount(accNum);
            if(result != null)
            {
                lblSearchBalance.Text = "Balance: $" + result.getBalance();
                lblSearchOwner.Text = "Owner: " + result.getOwner();
            }
            else
            {
                lblSearchOwner.Text = "Account " + accNum + " not found...";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accountListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportForm rf = new ReportForm(am, this);
            rf.ShowDialog();
        }
    }
}
