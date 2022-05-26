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
    public partial class ThankYou : Form
    {
        private int _ticks;
        public ThankYou()
        {
            InitializeComponent();
            timer1.Start();
           
        }

        private void ThankYou_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if (_ticks == 1)
            {
                this.Hide();
                Home h = new Home();
                h.ShowDialog();
            }
        }
    }
}
