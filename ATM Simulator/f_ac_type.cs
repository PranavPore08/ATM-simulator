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
    public partial class f_ac_type : Form
    {
        public f_ac_type()
        {
            InitializeComponent();
        }

        private void btn_pin_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_pin f = new f_pin();
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cash_withdrawal_Click(object sender, EventArgs e)
        {
            this.Hide();
            f_pin f = new f_pin();
            f.ShowDialog();
        }

        public static int card;
        public static int balance;
        
        
        private void f_ac_type_Load(object sender, EventArgs e)
        {
            card = FastCash.card;
            balance = FastCash.balance;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
