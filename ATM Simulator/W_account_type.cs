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
    public partial class W_account_type : Form
    {
        public W_account_type()
        {
            InitializeComponent();
        }

        public static int card;
        public static int balance;
        private void W_account_type_Load(object sender, EventArgs e)
        {
            card = Withdrawal.card;
            balance = Withdrawal.balance;
        }

        private void btn_pin_Click(object sender, EventArgs e)
        {
            this.Hide();
            w_pin w = new w_pin();
            w.ShowDialog();
        }

        private void btn_cash_withdrawal_Click(object sender, EventArgs e)
        {
            this.Hide();
            w_pin w = new w_pin();
            w.ShowDialog();
        }
    }
}
