
namespace Two_tier_Application
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.business_dataDataSet = new Two_tier_Application.Business_dataDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new Two_tier_Application.Business_dataDataSetTableAdapters.CategoriesTableAdapter();
            this.tableAdapterManager = new Two_tier_Application.Business_dataDataSetTableAdapters.TableAdapterManager();
            this.machinesTableAdapter = new Two_tier_Application.Business_dataDataSetTableAdapters.MachinesTableAdapter();
            this.fKMachinescatego3EDC53F0BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoriesTableAdapter1 = new Two_tier_Application.Business_dataDataSetTableAdapters.CategoriesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.machinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.machinesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKOrdersMachine589C25F3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Two_tier_Application.Business_dataDataSetTableAdapters.OrdersTableAdapter();
            this.machineidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKOrdersMachine589C25F3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKMachinescatego3EDC53F0BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.years = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.business_dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMachinescatego3EDC53F0BindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersMachine589C25F3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersMachine589C25F3BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMachinescatego3EDC53F0BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // business_dataDataSet
            // 
            this.business_dataDataSet.DataSetName = "Business_dataDataSet";
            this.business_dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.business_dataDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager.DriverTableAdapter = null;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.machine__testTableAdapter = null;
            this.tableAdapterManager.MachinesTableAdapter = this.machinesTableAdapter;
            this.tableAdapterManager.MembershipTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.Rating_scoreTableAdapter = null;
            this.tableAdapterManager.RatingsTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Two_tier_Application.Business_dataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // machinesTableAdapter
            // 
            this.machinesTableAdapter.ClearBeforeFill = true;
            // 
            // fKMachinescatego3EDC53F0BindingSource
            // 
            this.fKMachinescatego3EDC53F0BindingSource.DataMember = "FK__Machines__catego__3EDC53F0";
            this.fKMachinescatego3EDC53F0BindingSource.DataSource = this.categoriesBindingSource;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.categoriesDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // categoriesDataGridView
            // 
            this.categoriesDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.categoriesDataGridView.AutoGenerateColumns = false;
            this.categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.categoriesDataGridView.DataSource = this.categoriesBindingSource;
            this.categoriesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.categoriesDataGridView.Name = "categoriesDataGridView";
            this.categoriesDataGridView.RowTemplate.Height = 24;
            this.categoriesDataGridView.Size = new System.Drawing.Size(796, 220);
            this.categoriesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "category_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "category_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn2.HeaderText = "description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ProductList";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.categoriesBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "category_id";
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.machineidDataGridViewTextBoxColumn,
            this.years,
            this.price,
            this.title,
            this.condition});
            this.dataGridView1.DataSource = this.fKMachinescatego3EDC53F0BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // machinesBindingSource
            // 
            this.machinesBindingSource.DataMember = "Machines";
            this.machinesBindingSource.DataSource = this.business_dataDataSet;
            // 
            // machinesBindingSource1
            // 
            this.machinesBindingSource1.DataMember = "Machines";
            this.machinesBindingSource1.DataSource = this.business_dataDataSet;
            // 
            // fKOrdersMachine589C25F3BindingSource
            // 
            this.fKOrdersMachine589C25F3BindingSource.DataMember = "FK__Orders__Machine___589C25F3";
            this.fKOrdersMachine589C25F3BindingSource.DataSource = this.machinesBindingSource;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // machineidDataGridViewTextBoxColumn
            // 
            this.machineidDataGridViewTextBoxColumn.DataPropertyName = "Machine_id";
            this.machineidDataGridViewTextBoxColumn.HeaderText = "Machine_id";
            this.machineidDataGridViewTextBoxColumn.Name = "machineidDataGridViewTextBoxColumn";
            this.machineidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKOrdersMachine589C25F3BindingSource1
            // 
            this.fKOrdersMachine589C25F3BindingSource1.DataMember = "FK__Orders__Machine___589C25F3";
            this.fKOrdersMachine589C25F3BindingSource1.DataSource = this.machinesBindingSource;
            // 
            // fKMachinescatego3EDC53F0BindingSource1
            // 
            this.fKMachinescatego3EDC53F0BindingSource1.DataMember = "FK__Machines__catego__3EDC53F0";
            this.fKMachinescatego3EDC53F0BindingSource1.DataSource = this.categoriesBindingSource;
            // 
            // years
            // 
            this.years.DataPropertyName = "years";
            this.years.HeaderText = "years";
            this.years.Name = "years";
            this.years.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // condition
            // 
            this.condition.DataPropertyName = "condition";
            this.condition.HeaderText = "condition";
            this.condition.Name = "condition";
            this.condition.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.business_dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMachinescatego3EDC53F0BindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersMachine589C25F3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrdersMachine589C25F3BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMachinescatego3EDC53F0BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Business_dataDataSet business_dataDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Business_dataDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private Business_dataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Business_dataDataSetTableAdapters.MachinesTableAdapter machinesTableAdapter;
        private System.Windows.Forms.BindingSource fKMachinescatego3EDC53F0BindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView categoriesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource machinesBindingSource;
        private Business_dataDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private System.Windows.Forms.BindingSource machinesBindingSource1;
        private System.Windows.Forms.BindingSource fKOrdersMachine589C25F3BindingSource;
        private Business_dataDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKOrdersMachine589C25F3BindingSource1;
        private System.Windows.Forms.BindingSource fKMachinescatego3EDC53F0BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn years;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn condition;
    }
}

