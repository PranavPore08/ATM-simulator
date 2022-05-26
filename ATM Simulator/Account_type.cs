using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Simulator
{
    public partial class Account_type : Form
    {
        public Account_type()
        {
            InitializeComponent();
        }

        private void btn_cash_withdrawal_Click(object sender, EventArgs e)
        {

            this.Hide();
            PIN p = new PIN();
            p.ShowDialog();
        }

        private void btn_pin_Click(object sender, EventArgs e)
        {
            this.Hide();
            PIN p = new PIN();
            p.ShowDialog();
        }

        
        public static int card;
        public static int balance;
        private void Account_type_Load(object sender, EventArgs e)
        {
            card =Deposit.card;
            balance = Deposit.balance;   
        }
    }
}
