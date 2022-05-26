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
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services s = new Services();
            s.ShowDialog();
        }
        private void btn_deposit_Click(object sender, EventArgs e)
        {
            balance = 100;
            this.Hide();
            f_ac_type a = new f_ac_type();
            a.ShowDialog();
        }
        private void btn_fast_Click(object sender, EventArgs e)
        {
            balance = 500;
            this.Hide();
            f_ac_type a = new f_ac_type();
            a.ShowDialog();
        }

        private void btn_pin_Click(object sender, EventArgs e)
        {
            balance = 1000;
            this.Hide();
            f_ac_type a = new f_ac_type();
            a.ShowDialog();
        }

        private void btn_cash_withdrawal_Click(object sender, EventArgs e)
        {
            balance = 2000;
            this.Hide();
            f_ac_type a = new f_ac_type();
            a.ShowDialog();
        }

        private void btn_mini_state_Click(object sender, EventArgs e)
        {
            balance = 5000;
            this.Hide();
            f_ac_type a = new f_ac_type();
            a.ShowDialog();
        }

        private void btn_balance_Click(object sender, EventArgs e)
        {
            balance = 10000;
            this.Hide();
            f_ac_type a = new f_ac_type();
            a.ShowDialog();
        }

        public static int card;
        public static int balance;
        private void FastCash_Load(object sender, EventArgs e)
        {
            card = Services.card;
        }
    }
}
