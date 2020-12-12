using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Two_tier_Application
{
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }        

        private void button1_Click(object sender, EventArgs e)
        { 
            string AccountInf = "server=140.118.5.90;uid=Softengin;pwd=Softengin01;database=LongMeter";
            MySqlConnection conn = new MySqlConnection(AccountInf); //資料庫連接
            try
            {
                conn.Open();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("無法連線到資料庫.");
                        break;
                    case 1045:
                        MessageBox.Show("使用者帳號或密碼錯誤,請再試一次.");
                        break;
                }
            }
            if (textBox1.Text=="Admin" && textBox2.Text == "123")
            {
                button2.Visible=true;
                button3.Visible = true;
            }
            else
            {
                MessageBox.Show("輸入錯誤!");
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
