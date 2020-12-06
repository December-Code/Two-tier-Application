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

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.business_dataDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'business_dataDataSet1.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter1.Fill(this.business_dataDataSet1.Machines);
            // TODO: 這行程式碼會將資料載入 'business_dataDataSet.Orders' 資料表。您可以視需要進行移動或移除。
            this.ordersTableAdapter.Fill(this.business_dataDataSet.Orders);
            // TODO: 這行程式碼會將資料載入 'business_dataDataSet.Machines' 資料表。您可以視需要進行移動或移除。
            this.machinesTableAdapter.Fill(this.business_dataDataSet.Machines);
            // TODO: 這行程式碼會將資料載入 'business_dataDataSet.Categories' 資料表。您可以視需要進行移動或移除。
            this.categoriesTableAdapter.Fill(this.business_dataDataSet.Categories);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.machinesTableAdapter1.FillBy(this.business_dataDataSet1.Machines, ((int)(System.Convert.ChangeType(keywordToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
