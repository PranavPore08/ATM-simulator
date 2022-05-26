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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThankYou t=new ThankYou();
            t.ShowDialog();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services s = new Services();
            s.ShowDialog();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            balance = Convert.ToInt32(richTextBox1.Text);
            this.Hide();
            Account_type a = new Account_type();
            a.ShowDialog();
        }
        public static int card;
        public static int balance;
        private void Deposit_Load(object sender, EventArgs e)
        {
            card = Services.card;
        }
    }
}
