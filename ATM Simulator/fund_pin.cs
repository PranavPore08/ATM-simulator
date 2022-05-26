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
    public partial class fund_pin : Form
    {
        public fund_pin()
        {
            InitializeComponent();
        }
        public static int card;
        public static int receiver_card;
        public static int balance;

        private void fund_pin_Load(object sender, EventArgs e)
        {
            card = amount.card;
            receiver_card = amount.receiver_card;
            balance = amount.balance;
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
                    int n = c.Deposite(receiver_card, balance);
                    if (n > 0)
                    {
                        MessageBox.Show("Fund Transfer Successfully");
                        this.Hide();
                        ThankYou t = new ThankYou();
                        t.ShowDialog();
                    }
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
