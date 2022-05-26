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
    public partial class w_pin : Form
    {
        public w_pin()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            W_account_type w = new W_account_type();
            w.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static int card;
        public static int balance;
        private void w_pin_Load(object sender, EventArgs e)
        {
            card = W_account_type.card;
            balance = W_account_type.balance;
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            int pin = Convert.ToInt32(textBox1.Text);
            int p = c.check_pin(pin, card);
            if (p == 1)
            {
                int no = c.Withdrawal(card, balance);
                if (no > 0)
                {
                    MessageBox.Show("Get Your Cash");
                    this.Hide();
                    ThankYou t = new ThankYou();
                    t.ShowDialog(); ;
                }
                else if (no == -1)
                {
                    MessageBox.Show("Insufficient Balance");
                    this.Hide();
                    ThankYou t = new ThankYou();
                    t.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Wrong PIN");
                this.Hide();
                ThankYou t = new ThankYou();
                t.ShowDialog();
            }
        }
    }
}
