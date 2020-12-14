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
    public partial class Machine_Order : Form
    {
        public Machine_Order()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.longMeter_Orders);

        }

        private void Machine_Order_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'longMeter_Comments.Comments' 資料表。您可以視需要進行移動或移除。
            this.commentsTableAdapter.Fill(this.longMeter_Comments.Comments);
            // TODO: 這行程式碼會將資料載入 'longMeter_DataDataSet3.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter3.Fill(this.longMeter_DataDataSet3.Membership);
            // TODO: 這行程式碼會將資料載入 'longMeter_Ratings.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter2.Fill(this.longMeter_Ratings.Membership);
            // TODO: 這行程式碼會將資料載入 'longMeter_Ratings.Ratings' 資料表。您可以視需要進行移動或移除。
            this.ratingsTableAdapter.Fill(this.longMeter_Ratings.Ratings);
            // TODO: 這行程式碼會將資料載入 'longMeter_Orders.Staff' 資料表。您可以視需要進行移動或移除。
            this.staffTableAdapter.Fill(this.longMeter_Orders.Staff);
            // TODO: 這行程式碼會將資料載入 'longMeter_DataDataSet2.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter1.Fill(this.longMeter_DataDataSet2.Membership);
            // TODO: 這行程式碼會將資料載入 'longMeter_Orders.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter.Fill(this.longMeter_Orders.Membership);
            // TODO: 這行程式碼會將資料載入 'longMeter_Orders.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter.Fill(this.longMeter_Orders.Machines);
            // TODO: 這行程式碼會將資料載入 'longMeter_DataDataSet3.Advertisement' 資料表。您可以視需要進行移動或移除。
            this.advertisementTableAdapter.Fill(this.longMeter_Advertisement.Advertisement);
            // TODO: 這行程式碼會將資料載入 'longMeter_Orders.Orders' 資料表。您可以視需要進行移動或移除。
            this.ordersTableAdapter.Fill(this.longMeter_Orders.Orders);

        }


        private void bindingNavigatorSaveItem1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.advertisementBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.longMeter_Advertisement);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ordersTableAdapter.InsertQuery(
                Convert.ToInt32(comboBox1.Text),
                Convert.ToInt32(comboBox2.Text),
                Convert.ToInt32(comboBox3.Text),
                Convert.ToInt32(comboBox4.Text),
                Convert.ToInt32(textBox2.Text),
                Convert.ToDouble(textBox3.Text),
                Convert.ToString(comboBox5.Text)
                );
            MessageBox.Show("successfully added!");
        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.Search(this.longMeter_Orders.Orders, ((int)(System.Convert.ChangeType(keywordToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.Update1(this.longMeter_Orders.Orders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void HideFinishi_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordersTableAdapter.HideFinish(this.longMeter_Orders.Orders);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            advertisementTableAdapter.InsertQuery(
                textBox5.Text,
                textBox6.Text
            );
            MessageBox.Show("successfully added!");
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ratingsTableAdapter.InsertQuery(
                Convert.ToInt32(comboBox6.Text),
                Convert.ToInt32(comboBox7.Text),
                Convert.ToInt32(comboBox8.Text)
                );
            MessageBox.Show("successfully added!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("successfully published!");
        }
    }
}
