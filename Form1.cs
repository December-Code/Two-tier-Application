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
    public partial class Form1 : Form
    {
        public Form1()
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
            // TODO: 這行程式碼會將資料載入 'longMeter_Machine.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter1.Fill(this.longMeter_Machine.Machines);
            // TODO: 這行程式碼會將資料載入 'longMeter_DataDataSet.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter.Fill(this.longMeter_DataDataSet.Machines);

        }

        private void Machine_id_SearchToolStripButton_Click(object sender, EventArgs e)
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
                    this.machinesTableAdapter1.Category_id_Search(this.longMeter_Machine.Machines, ((int)(System.Convert.ChangeType(keywordToolStripTextBox.Text, typeof(int)))));
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
                    this.machinesTableAdapter1.Price_Search(this.longMeter_Machine.Machines, ((double)(System.Convert.ChangeType(keywordToolStripTextBox.Text, typeof(double)))));
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
                    this.machinesTableAdapter1.Title_Search(this.longMeter_Machine.Machines, keywordToolStripTextBox.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
