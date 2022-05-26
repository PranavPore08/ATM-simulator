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
    public partial class amount : Form
    {
        public amount()
        {
            InitializeComponent();
        }
        public static int card;
        public static int receiver_card;
        public static int balance;

        private void amount_Load(object sender, EventArgs e)
        {
            card = receiver.card;
            receiver_card = receiver.receiver_card;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Complete the Field");
            }
            else
            {
                balance= Convert.ToInt32(richTextBox1.Text);
                this.Hide();
                fund_pin f = new fund_pin();
                f.ShowDialog();
            }
        }
    }
}
