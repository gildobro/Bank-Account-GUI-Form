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
    public partial class ReportForm : Form
    {
        AccountManager am;
        Form1 link;
        public ReportForm(AccountManager aMan, Form1 x)
        {
            link = x;
            this.am = aMan;
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("acNum", "Account #");
            dataGridView1.Columns.Add("bal", "Balance $");
            dataGridView1.Columns.Add("own", "Owner");
            int numAccounts = am.getNumAccounts();
            for(int x = 0; x < numAccounts; x++)
            {
                Account result = am.GetAccountByIndex(x);
                txtReportArea.Text += result;
                dataGridView1.Rows.Add(result.getAccNumber(), result.getBalance(), result.getOwner());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            link.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
