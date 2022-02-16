using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class AccountForm : Form
    {
        private List<Account> accounts;

        public AccountForm()
        {
            InitializeComponent();
            accounts = new List<Account>();
            cusChecking.Checked = true;
        }

        private void CheckingChange(object sender, EventArgs e)
        {
            if (cusChecking.Checked == true)
            {
                dailyWithdrawalLimit.Enabled = true;
                interestRate.Enabled = false;
            }
            else if (visa.Checked == true)
            {
                dailyWithdrawalLimit.Enabled = false;
                interestRate.Enabled = true;
            }
        }

        private void BtnCrtAccOnClick(object sender, EventArgs e)
        {
            try
            {
                Account account = null;
                int number = Convert.ToInt32(accountNumber.Text);
                if (clientName.Text == string.Empty)
                    throw new Exception("Client name can not be empty!");
                string name = clientName.Text;
                double balance = Convert.ToDouble(this.balance.Text);

                if (accounts.Exists(x => x.Number == number))
                {
                    MessageBox.Show("This account number already exist.Please enter another account number!", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cusChecking.Checked)
                {
                    double withdrawLimit = Convert.ToDouble(dailyWithdrawalLimit.Text);
                    account = new CheckingAccount(number, name, balance, withdrawLimit);
                    account.checkingAccount = true;
                }
                else if (visa.Checked)
                {
                    double interestRate = Convert.ToDouble(this.interestRate.Text);
                    account = new VisaAccount(number, name, balance, interestRate);
                    account.checkingAccount = false;
                }

                if (account != null)
                {
                    accounts.Add(account);
                    accountNumber.Text =
                    clientName.Text =
                    this.balance.Text =
                    dailyWithdrawalLimit.Text =
                    interestRate.Text = "";
                    cusChecking.Checked = true;
                    MessageBox.Show("Number of account stored: " + accounts.Count, 
                        "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSearchOnClick(object sender, EventArgs e)
        {
            try
            {
                int accountNumber = Convert.ToInt32(this.accountNumber.Text);
                Account account = accounts.Find(x => x.Number == accountNumber);
                if (account != null)
                {
                    clientName.Text = account.ClientName;
                    balance.Text = account.Balance.ToString();
                    if (account.checkingAccount == true)
                    {
                        dailyWithdrawalLimit.Text = ((CheckingAccount)account).WithdrawLimit.ToString();
                    }
                    else if (account.checkingAccount == false)
                    {
                        interestRate.Text = ((VisaAccount)account).InterestRate.ToString();
                    }
                }
                else
                    MessageBox.Show("Account not found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
