namespace Two_tier_Application
{
    partial class Machine_User
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
            System.Windows.Forms.Label conditionLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label paymentLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label yearsLabel;
            System.Windows.Forms.Label location_idLabel;
            System.Windows.Forms.Label category_idLabel;
            System.Windows.Forms.Label machine_idLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.machinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.longMeter_DataDataSet = new Two_tier_Application.LongMeter_DataDataSet();
            this.machinesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machinesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.longMeter_Machine = new Two_tier_Application.LongMeter_Machine();
            this.machine_id_SearchToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.keywordToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.keywordToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.machine_id_SearchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.machinesDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machinesTableAdapter1 = new Two_tier_Application.LongMeter_MachineTableAdapters.MachinesTableAdapter();
            this.tableAdapterManager1 = new Two_tier_Application.LongMeter_MachineTableAdapters.TableAdapterManager();
            this.machinesTableAdapter = new Two_tier_Application.LongMeter_DataDataSetTableAdapters.MachinesTableAdapter();
            this.tableAdapterManager = new Two_tier_Application.LongMeter_DataDataSetTableAdapters.TableAdapterManager();
            this.button2 = new System.Windows.Forms.Button();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.location_idTextBox = new System.Windows.Forms.TextBox();
            this.category_idTextBox = new System.Windows.Forms.TextBox();
            this.machine_idTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            conditionLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            yearsLabel = new System.Windows.Forms.Label();
            location_idLabel = new System.Windows.Forms.Label();
            category_idLabel = new System.Windows.Forms.Label();
            machine_idLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longMeter_DataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longMeter_Machine)).BeginInit();
            this.machine_id_SearchToolStrip.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.machinesDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1197, 703);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.machinesDataGridView);
            this.tabPage1.Controls.Add(this.machine_id_SearchToolStrip);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1189, 674);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Machine";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // machinesBindingSource
            // 
            this.machinesBindingSource.DataMember = "Machines";
            this.machinesBindingSource.DataSource = this.longMeter_DataDataSet;
            // 
            // longMeter_DataDataSet
            // 
            this.longMeter_DataDataSet.DataSetName = "LongMeter_DataDataSet";
            this.longMeter_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // machinesDataGridView
            // 
            this.machinesDataGridView.AutoGenerateColumns = false;
            this.machinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.machinesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.machinesDataGridView.DataSource = this.machinesBindingSource1;
            this.machinesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.machinesDataGridView.Location = new System.Drawing.Point(3, 33);
            this.machinesDataGridView.Name = "machinesDataGridView";
            this.machinesDataGridView.RowHeadersWidth = 51;
            this.machinesDataGridView.RowTemplate.Height = 27;
            this.machinesDataGridView.Size = new System.Drawing.Size(1183, 638);
            this.machinesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Machine_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Machine_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "category_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "category_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Driver_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Driver_id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "location_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "location_id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "years";
            this.dataGridViewTextBoxColumn5.HeaderText = "years";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn6.HeaderText = "price";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "payment";
            this.dataGridViewTextBoxColumn7.HeaderText = "payment";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn8.HeaderText = "title";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "condition";
            this.dataGridViewTextBoxColumn9.HeaderText = "condition";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // machinesBindingSource1
            // 
            this.machinesBindingSource1.DataMember = "Machines";
            this.machinesBindingSource1.DataSource = this.longMeter_Machine;
            // 
            // longMeter_Machine
            // 
            this.longMeter_Machine.DataSetName = "LongMeter_Machine";
            this.longMeter_Machine.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // machine_id_SearchToolStrip
            // 
            this.machine_id_SearchToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.machine_id_SearchToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.machine_id_SearchToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.machine_id_SearchToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox,
            this.keywordToolStripLabel,
            this.keywordToolStripTextBox,
            this.machine_id_SearchToolStripButton});
            this.machine_id_SearchToolStrip.Location = new System.Drawing.Point(0, 3);
            this.machine_id_SearchToolStrip.Name = "machine_id_SearchToolStrip";
            this.machine_id_SearchToolStrip.Size = new System.Drawing.Size(466, 27);
            this.machine_id_SearchToolStrip.TabIndex = 2;
            this.machine_id_SearchToolStrip.Text = "machine_id_SearchToolStrip";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(41, 24);
            this.toolStripLabel1.Text = "Kind";
            // 
            // toolStripComboBox
            // 
            this.toolStripComboBox.Items.AddRange(new object[] {
            "Machine_id",
            "category_id",
            "price",
            "title"});
            this.toolStripComboBox.Name = "toolStripComboBox";
            this.toolStripComboBox.Size = new System.Drawing.Size(125, 27);
            this.toolStripComboBox.Text = "Machine_id";
            // 
            // keywordToolStripLabel
            // 
            this.keywordToolStripLabel.Name = "keywordToolStripLabel";
            this.keywordToolStripLabel.Size = new System.Drawing.Size(73, 24);
            this.keywordToolStripLabel.Text = "keyword:";
            // 
            // keywordToolStripTextBox
            // 
            this.keywordToolStripTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.keywordToolStripTextBox.Name = "keywordToolStripTextBox";
            this.keywordToolStripTextBox.Size = new System.Drawing.Size(150, 27);
            // 
            // machine_id_SearchToolStripButton
            // 
            this.machine_id_SearchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.machine_id_SearchToolStripButton.Name = "machine_id_SearchToolStripButton";
            this.machine_id_SearchToolStripButton.Size = new System.Drawing.Size(60, 24);
            this.machine_id_SearchToolStripButton.Text = "Search";
            this.machine_id_SearchToolStripButton.ToolTipText = "Machine_id_Search";
            this.machine_id_SearchToolStripButton.Click += new System.EventHandler(this.machine_id_SearchToolStripButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1189, 674);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(machine_idLabel);
            this.tabPage3.Controls.Add(this.machine_idTextBox);
            this.tabPage3.Controls.Add(category_idLabel);
            this.tabPage3.Controls.Add(this.category_idTextBox);
            this.tabPage3.Controls.Add(location_idLabel);
            this.tabPage3.Controls.Add(this.location_idTextBox);
            this.tabPage3.Controls.Add(yearsLabel);
            this.tabPage3.Controls.Add(this.yearsTextBox);
            this.tabPage3.Controls.Add(priceLabel);
            this.tabPage3.Controls.Add(this.priceTextBox);
            this.tabPage3.Controls.Add(paymentLabel);
            this.tabPage3.Controls.Add(this.paymentTextBox);
            this.tabPage3.Controls.Add(titleLabel);
            this.tabPage3.Controls.Add(this.titleTextBox);
            this.tabPage3.Controls.Add(conditionLabel);
            this.tabPage3.Controls.Add(this.conditionTextBox);
            this.tabPage3.Controls.Add(this.machinesDataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1189, 674);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add_M";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // machinesDataGridView1
            // 
            this.machinesDataGridView1.AutoGenerateColumns = false;
            this.machinesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.machinesDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.machinesDataGridView1.DataSource = this.machinesBindingSource;
            this.machinesDataGridView1.Location = new System.Drawing.Point(416, 6);
            this.machinesDataGridView1.Name = "machinesDataGridView1";
            this.machinesDataGridView1.RowHeadersWidth = 51;
            this.machinesDataGridView1.RowTemplate.Height = 27;
            this.machinesDataGridView1.Size = new System.Drawing.Size(773, 496);
            this.machinesDataGridView1.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Machine_id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Machine_id";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "category_id";
            this.dataGridViewTextBoxColumn11.HeaderText = "category_id";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Driver_id";
            this.dataGridViewTextBoxColumn12.HeaderText = "Driver_id";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "location_id";
            this.dataGridViewTextBoxColumn13.HeaderText = "location_id";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "years";
            this.dataGridViewTextBoxColumn14.HeaderText = "years";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn15.HeaderText = "price";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "payment";
            this.dataGridViewTextBoxColumn16.HeaderText = "payment";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn17.HeaderText = "title";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "condition";
            this.dataGridViewTextBoxColumn18.HeaderText = "condition";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // machinesTableAdapter1
            // 
            this.machinesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.MachinesTableAdapter = this.machinesTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Two_tier_Application.LongMeter_MachineTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // machinesTableAdapter
            // 
            this.machinesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.CommentsTableAdapter = null;
            this.tableAdapterManager.CountrysTableAdapter = null;
            this.tableAdapterManager.DriverTableAdapter = null;
            this.tableAdapterManager.LocationsTableAdapter = null;
            this.tableAdapterManager.MachinesTableAdapter = this.machinesTableAdapter;
            this.tableAdapterManager.MembershipTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.RatingsTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Two_tier_Application.LongMeter_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "condition", true));
            this.conditionTextBox.Location = new System.Drawing.Point(105, 330);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(301, 25);
            this.conditionTextBox.TabIndex = 36;
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(24, 333);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(64, 15);
            conditionLabel.TabIndex = 35;
            conditionLabel.Text = "condition:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "title", true));
            this.titleTextBox.Location = new System.Drawing.Point(105, 299);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(301, 25);
            this.titleTextBox.TabIndex = 34;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(24, 302);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(33, 15);
            titleLabel.TabIndex = 33;
            titleLabel.Text = "title:";
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "payment", true));
            this.paymentTextBox.Location = new System.Drawing.Point(105, 268);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(301, 25);
            this.paymentTextBox.TabIndex = 32;
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new System.Drawing.Point(24, 271);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(59, 15);
            paymentLabel.TabIndex = 31;
            paymentLabel.Text = "payment:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(105, 237);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(301, 25);
            this.priceTextBox.TabIndex = 30;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(24, 240);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(39, 15);
            priceLabel.TabIndex = 29;
            priceLabel.Text = "price:";
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "years", true));
            this.yearsTextBox.Location = new System.Drawing.Point(105, 206);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(301, 25);
            this.yearsTextBox.TabIndex = 28;
            // 
            // yearsLabel
            // 
            yearsLabel.AutoSize = true;
            yearsLabel.Location = new System.Drawing.Point(24, 209);
            yearsLabel.Name = "yearsLabel";
            yearsLabel.Size = new System.Drawing.Size(40, 15);
            yearsLabel.TabIndex = 27;
            yearsLabel.Text = "years:";
            // 
            // location_idTextBox
            // 
            this.location_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "location_id", true));
            this.location_idTextBox.Location = new System.Drawing.Point(105, 175);
            this.location_idTextBox.Name = "location_idTextBox";
            this.location_idTextBox.Size = new System.Drawing.Size(301, 25);
            this.location_idTextBox.TabIndex = 26;
            // 
            // location_idLabel
            // 
            location_idLabel.AutoSize = true;
            location_idLabel.Location = new System.Drawing.Point(24, 178);
            location_idLabel.Name = "location_idLabel";
            location_idLabel.Size = new System.Drawing.Size(71, 15);
            location_idLabel.TabIndex = 25;
            location_idLabel.Text = "location id:";
            // 
            // category_idTextBox
            // 
            this.category_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "category_id", true));
            this.category_idTextBox.Location = new System.Drawing.Point(105, 138);
            this.category_idTextBox.Name = "category_idTextBox";
            this.category_idTextBox.Size = new System.Drawing.Size(301, 25);
            this.category_idTextBox.TabIndex = 22;
            // 
            // category_idLabel
            // 
            category_idLabel.AutoSize = true;
            category_idLabel.Location = new System.Drawing.Point(24, 141);
            category_idLabel.Name = "category_idLabel";
            category_idLabel.Size = new System.Drawing.Size(74, 15);
            category_idLabel.TabIndex = 21;
            category_idLabel.Text = "category id:";
            // 
            // machine_idTextBox
            // 
            this.machine_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.machinesBindingSource, "Machine_id", true));
            this.machine_idTextBox.Location = new System.Drawing.Point(105, 107);
            this.machine_idTextBox.Name = "machine_idTextBox";
            this.machine_idTextBox.Size = new System.Drawing.Size(301, 25);
            this.machine_idTextBox.TabIndex = 20;
            // 
            // machine_idLabel
            // 
            machine_idLabel.AutoSize = true;
            machine_idLabel.Location = new System.Drawing.Point(24, 110);
            machine_idLabel.Name = "machine_idLabel";
            machine_idLabel.Size = new System.Drawing.Size(75, 15);
            machine_idLabel.TabIndex = 19;
            machine_idLabel.Text = "Machine id:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Machine_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 703);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Machine_User";
            this.Text = "Machine&User";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longMeter_DataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machinesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longMeter_Machine)).EndInit();
            this.machine_id_SearchToolStrip.ResumeLayout(false);
            this.machine_id_SearchToolStrip.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.machinesDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private LongMeter_DataDataSet longMeter_DataDataSet;
        private System.Windows.Forms.BindingSource machinesBindingSource;
        private LongMeter_DataDataSetTableAdapters.MachinesTableAdapter machinesTableAdapter;
        private LongMeter_DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabPage tabPage3;
        private LongMeter_Machine longMeter_Machine;
        private System.Windows.Forms.BindingSource machinesBindingSource1;
        private LongMeter_MachineTableAdapters.MachinesTableAdapter machinesTableAdapter1;
        private LongMeter_MachineTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView machinesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ToolStrip machine_id_SearchToolStrip;
        private System.Windows.Forms.ToolStripLabel keywordToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox keywordToolStripTextBox;
        private System.Windows.Forms.ToolStripButton machine_id_SearchToolStripButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox;
        private System.Windows.Forms.DataGridView machinesDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox machine_idTextBox;
        private System.Windows.Forms.TextBox category_idTextBox;
        private System.Windows.Forms.TextBox location_idTextBox;
        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.Button button3;
    }
}

