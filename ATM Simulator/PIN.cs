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
    public partial class PIN : Form
    {
        public PIN()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account_type a = new Account_type();
            a.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThankYou t = new ThankYou();
            t.ShowDialog();
        }
        public static int card;
        public static int balance;
        private void PIN_Load(object sender, EventArgs e)
        {
            card = Deposit.card;
            balance = Deposit.balance;
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            int pin = Convert.ToInt32(textBox1.Text);
            int p=c.check_pin(pin,card);
            if (p == 1)
            {
                int no = c.Deposite(card, balance);
                if (no > 0)
                {
                    MessageBox.Show("Deposited Successfully");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
