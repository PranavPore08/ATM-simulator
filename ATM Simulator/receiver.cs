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
    public partial class receiver : Form
    {
        public receiver()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Enter ID");
            }
            else
            {
                Class1 cl = new Class1();
                int c= Convert.ToInt32(richTextBox1.Text);
                int no = cl.check_card(c);
                if (no ==1)
                {
                    receiver_card = c;
                    this.Hide();
                    amount a = new amount();
                    a.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Enter Correct ID");
                    richTextBox1.Text = "";
                }
            }

        }
        public static int card;
        public static int receiver_card;

        private void receiver_Load(object sender, EventArgs e)
        {
            card = number.card;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services s = new Services();
            s.ShowDialog();
        }
    }
}
