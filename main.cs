﻿using System;
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
            if (textBox1.Text=="Admin" && textBox2.Text == "123")
            {
                
            }
            else
            {
                MessageBox.Show("輸入錯誤!");
            }
        }
    }
}
