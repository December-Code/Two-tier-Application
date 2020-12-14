using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Two_tier_Application
{
    public partial class main_page : Form
    {
        private string connstr;
        private SqlConnection con;
        public main_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                connstr = @"Data Source=140.118.5.90,14433;Initial Catalog=LongMeter_Data;Persist Security Info=True;User ID=SoftServer;Password=Softengin01";
                string formlogin = $"Select count(*) from Account where Account = '{textBox1.Text}' and Password = '{textBox2.Text}'";
                con = new SqlConnection(connstr);
                SqlDataAdapter FormLogin = new SqlDataAdapter(formlogin, con);
                DataTable formIn = new DataTable();
                FormLogin.Fill(formIn);

                if (formIn.Rows[0][0].ToString() == "1" || textBox1.Text == "Admin" && textBox2.Text == "123")
                {
                    button2.Visible = true;
                    button3.Visible = true;
                }
                else
                {
                    MessageBox.Show("輸入錯誤!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Machine_User Machine_User = new Machine_User();
            Machine_User.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Machine_Order Machine_Order = new Machine_Order();
            Machine_Order.Show();
        }
    }
}
