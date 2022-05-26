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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void btn_fast_Click(object sender, EventArgs e)
        {
            if (txt_balance.Text == "" || txt_card.Text == "" || txt_mobile.Text == "" || txt_name.Text == "" || txt_pin.Text == "")
            {
                MessageBox.Show("Complete Fields Properly");
                txt_balance.Text = ""; 
                txt_card.Text =""; 
                txt_mobile.Text = "";  
                txt_name.Text = ""; 
                txt_pin.Text = "";
            }
            else
            {
                int pin = Convert.ToInt32(txt_pin.Text);
                int card = Convert.ToInt32(txt_card.Text);
                int balance = Convert.ToInt32(txt_balance.Text);
                Class1 c = new Class1();
                int no = c.Add_user(card, txt_name.Text, pin, txt_mobile.Text, balance);
                if (no > 0)
                {
                    MessageBox.Show("Your Data Added Successfully...");
                    this.Hide();
                    Login l = new Login();
                    l.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
