namespace ATM_Simulator
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static int card_no;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if (txt_pin.Text == "" && txt_card.Text == "")
            {
                MessageBox.Show("Enter Deails");
            }
            else
            {
                Class1 c = new Class1();
                int card = Convert.ToInt32(txt_card.Text);
                int p = Convert.ToInt32(txt_pin.Text);
                int no = c.Login(card, p);
                if (no > 0)
                {
                    MessageBox.Show("Login Successfully...");
                    card_no = card; 
                    this.Hide();
                    number n = new number();
                    n.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Enter Correct Details");
                    txt_card.Text = "";
                    txt_pin.Text = "";
                }
            }
        }
    }
}