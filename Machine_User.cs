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
    public partial class Machine_User : Form
    {
        public Machine_User()
        {
            InitializeComponent();
        }

        private void machinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.machinesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.longMeter_DataDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'longMeter_Members.Membership' 資料表。您可以視需要進行移動或移除。
            this.membershipTableAdapter.Fill(this.longMeter_Members.Membership);
            // TODO: 這行程式碼會將資料載入 'longMeter_Machine.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter1.Fill(this.longMeter_Machine.Machines);
            // TODO: 這行程式碼會將資料載入 'longMeter_DataDataSet.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter.Fill(this.longMeter_DataDataSet.Machines);

        }

        private void machine_id_SearchToolStripButton_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox.Text == "Machine_id")
            {
                try
                {
                    this.machinesTableAdapter1.Machine_id_Search(this.longMeter_Machine.Machines, ((int)(System.Convert.ChangeType(keywordToolStripTextBox.Text, typeof(int)))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else if (toolStripComboBox.Text == "category_id")
            {
                try
                {
                    this.machinesTableAdapter1.category_id_Search(this.longMeter_Machine.Machines, ((int)(System.Convert.ChangeType(keywordToolStripTextBox.Text, typeof(int)))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else if (toolStripComboBox.Text == "price")
            {
                try
                {
                    this.machinesTableAdapter1.price_Search(this.longMeter_Machine.Machines, ((double)(System.Convert.ChangeType(keywordToolStripTextBox.Text, typeof(double)))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else if (toolStripComboBox.Text == "title")
            {
                try
                {
                    this.machinesTableAdapter1.title_Search(this.longMeter_Machine.Machines, keywordToolStripTextBox.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            machinesTableAdapter.InsertQuery_addM(
               int.Parse(machine_idTextBox.Text),
               int.Parse(category_idTextBox.Text),
               //int.Parse(driver_idTextBox.Text),
               int.Parse(location_idTextBox.Text),
               int.Parse(yearsTextBox.Text),
               double.Parse(priceTextBox.Text),
               paymentTextBox.Text,
               titleTextBox.Text,
               conditionTextBox.Text
               );
            MessageBox.Show("Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            machinesTableAdapter.DeleteQuery(
                int.Parse(machine_idTextBox.Text)
                );
            MessageBox.Show("Delete");
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            membershipTableAdapter.InsertQuery(
                int.Parse(member_idTextBox.Text),
                emailTextBox.Text,
                int.Parse(phoneTextBox.Text),
                first_nameTextBox.Text,
                last_nameTextBox.Text,
                adressTextBox.Text,
                birth_DateTextBox.Text
                );
            MessageBox.Show("Successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            membershipTableAdapter.DeleteQuery(
                int.Parse(member_idTextBox.Text)
                );
            MessageBox.Show("Delete");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_page main = new main_page();
            main.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_page main = new main_page();
            main.Show();
        }
    }
}

