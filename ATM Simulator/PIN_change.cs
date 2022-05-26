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
    public partial class PIN_change : Form
    {
        public PIN_change()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services s = new Services();
            s.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThankYou t = new ThankYou();
            t.ShowDialog();
        }

        private void btn_deposit_Click(object sender, EventArgs e)
        {
            if(txt_conf.Text=="" || txt_cur.Text=="" || txt_new.Text== "")
            {
                MessageBox.Show("Complete Fields");
            }
            else if (txt_new.Text != txt_conf.Text)
            {
                MessageBox.Show("PIN not matching");
            }
            else if(txt_new.Text == txt_conf.Text)
            {
                Class1 c = new Class1();
                int pre = Convert.ToInt32(txt_cur.Text);
                int conf = Convert.ToInt32(txt_conf.Text);
                int no=c.change_pin(pre,conf,card);
                if (no > 0)
                {
                    MessageBox.Show("Changed Successfully...");
                    this.Hide();
                    ThankYou t = new ThankYou();
                    t.ShowDialog();
                }
                else if (no == -1)
                {
                    MessageBox.Show("Enter correct Current Pin");
                }
                txt_conf.Text = "";
                txt_cur.Text = "";
                txt_new.Text = "";

            }
            
            
        }
        public static int card;
        private void PIN_change_Load(object sender, EventArgs e)
        {
            card = Services.card;
        }
    }
}
