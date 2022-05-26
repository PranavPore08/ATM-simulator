using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ATM_Simulator
{
    internal class Class1
    {
        SqlConnection s = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\ATMDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd;

        public int Add_user(int card, String name, int pin, String mobile, int balance)
        {
            String query="Insert into ATM_User values("+card+",'"+name+"',"+pin+",'" + mobile + "'," + balance + ")";
            s.Open();
            cmd = new SqlCommand(query, s);
            int no=cmd.ExecuteNonQuery();
            s.Close();
            return no;
        }

        public int Login(int card, int pin)
        {
            cmd = new SqlCommand("select * from ATM_USer where card_no="+card+" and PIN="+pin, s);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt); 
            s.Open();
            int i = cmd.ExecuteNonQuery();
            s.Close();
            return dt.Rows.Count;
        }

        public int check_card(int card)
        {
            cmd = new SqlCommand("select * from ATM_USer where card_no=" + card, s);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            s.Open();
            int i = cmd.ExecuteNonQuery();
            s.Close();
            return dt.Rows.Count;
        }

        public int Deposite(int card,int balance)
        {
            cmd = new SqlCommand("select * from ATM_USer where card_no=" + card, s);
            s.Open();
            String b = "";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                b = reader["balance"].ToString();
            }
            reader.Close();
            int bal=Convert.ToInt32(b);
            bal = bal + balance;
            String query = "Update Atm_user set Balance="+ bal +" Where card_no=" + card;
            cmd = new SqlCommand(query,s);
            int no = cmd.ExecuteNonQuery();
            s.Close();
            return no;
        }

        public int Withdrawal(int card, int balance)
        {

            cmd = new SqlCommand("select * from ATM_USer where card_no=" + card, s);
            s.Open();
            String b = "";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                b = reader["balance"].ToString();
            }
            reader.Close();
            int bal = Convert.ToInt32(b);
            bal = bal - balance;
            if (bal<=0)
            {
                return -1;
            }
            String query = "Update Atm_user set Balance=" + bal + " Where card_no=" + card;
            cmd = new SqlCommand(query, s);
            int no = cmd.ExecuteNonQuery();
            s.Close();
            return no;
        }

        public int change_pin(int ppin,int npin,int card)
        {
            cmd = new SqlCommand("select * from ATM_USer where card_no=" + card, s);
            s.Open();
            String b = "";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                b = reader["PIN"].ToString();
            }
            reader.Close();
            if (Convert.ToInt32(b) == ppin)
            {
                String query = "update ATM_user set pin=" +npin+ " where card_no="+card;
                cmd = new SqlCommand(query,s);
                int no=cmd.ExecuteNonQuery();
                s.Close();
                return no;
            }
            s.Close();
            return -1;
        }

        public int check_pin(int pin, int card)
        {
            cmd = new SqlCommand("select * from ATM_USer where card_no=" + card, s);
            s.Open();
            String b = "";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                b = reader["PIN"].ToString();
            }
            reader.Close();
            s.Close();
            if (Convert.ToInt32(b) == pin)
            {
                return 1;
            }
            return 0;
        }
        public String fetch_balance(int card)
        {
            cmd = new SqlCommand("select * from ATM_USer where card_no=" + card, s);
            s.Open();
            String b="";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                b = reader["balance"].ToString();
            }
            reader.Close();
            s.Close();
            return b; 
        }
    }
}

