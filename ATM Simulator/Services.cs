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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit d = new Deposit();
            d.ShowDialog();
        }

        private void btn_fast_Click(object sender, EventArgs e)
        {
            this.Hide();
            FastCash f = new FastCash();
            f.ShowDialog();
        }

        private void btn_cash_withdrawal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdrawal w = new Withdrawal();
            w.ShowDialog();
        }

        private void btn_pin_Click(object sender, EventArgs e)
        {   
            this.Hide();
            PIN_change p = new PIN_change();
            p.ShowDialog();
        }

        private void btn_balance_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            MessageBox.Show("Your balance is " + c.fetch_balance(Convert.ToInt32(card.ToString())));
        }
        public static int card;
        private void Services_Load(object sender, EventArgs e)
        {
            card= number.card;
        }

        private void btn_mini_state_Click(object sender, EventArgs e)
        {
            this.Hide();
            receiver r = new receiver();
            r.ShowDialog();
        }
    }
}
