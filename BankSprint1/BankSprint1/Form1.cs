using System;
using System.Windows.Forms;

namespace BankSprint1
{
    public partial class Form1 : Form
    {
        Customer customer = new Customer();
        Account selectedAccount;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Everyday", "Investment", "Omni" });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAccount = customer.GetAccounts()[comboBox1.SelectedIndex];
            labelInfo.Text = selectedAccount.GetAccountInfo();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtAmount.Text);
            listBox1.Items.Add(selectedAccount.Deposit(amount));
            labelInfo.Text = selectedAccount.GetAccountInfo();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(txtAmount.Text);
            listBox1.Items.Add(selectedAccount.Withdraw(amount));
            labelInfo.Text = selectedAccount.GetAccountInfo();
        }

        private void btnInterest_Click(object sender, EventArgs e)
        {
            double interest = selectedAccount.CalculateInterest();
            listBox1.Items.Add($"Interest Added: {interest}");
            labelInfo.Text = selectedAccount.GetAccountInfo();
        }
    }
}
