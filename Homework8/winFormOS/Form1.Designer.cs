namespace winFormOS
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addOrder = new System.Windows.Forms.Button();
            this.OrderListGrid = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.enterTB = new System.Windows.Forms.TextBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.changeOrder = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.importBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sortCbx = new System.Windows.Forms.ComboBox();
            this.sortBtn = new System.Windows.Forms.Button();
            this.osPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrderListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.osPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderServiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addOrder
            // 
            this.addOrder.Location = new System.Drawing.Point(16, 104);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(129, 64);
            this.addOrder.TabIndex = 0;
            this.addOrder.Text = "添加订单";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // OrderListGrid
            // 
            this.OrderListGrid.AutoGenerateColumns = false;
            this.OrderListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.Time,
            this.customerDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn});
            this.OrderListGrid.DataSource = this.orderServiceBindingSource;
            this.OrderListGrid.Location = new System.Drawing.Point(12, 222);
            this.OrderListGrid.Name = "OrderListGrid";
            this.OrderListGrid.ReadOnly = true;
            this.OrderListGrid.RowHeadersWidth = 51;
            this.OrderListGrid.RowTemplate.Height = 27;
            this.OrderListGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderListGrid.Size = new System.Drawing.Size(557, 352);
            this.OrderListGrid.TabIndex = 3;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "修改时间";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPrice});
            this.dataGridView1.DataSource = this.orderDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(573, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(510, 352);
            this.dataGridView1.TabIndex = 4;
            // 
            // totalPrice
            // 
            this.totalPrice.DataPropertyName = "totalPrice";
            this.totalPrice.HeaderText = "总金额";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            this.totalPrice.Width = 125;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "orderDetails";
            this.orderDetailsBindingSource.DataSource = this.orderServiceBindingSource;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "客户名"});
            this.comboBox1.Location = new System.Drawing.Point(33, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // enterTB
            // 
            this.enterTB.Location = new System.Drawing.Point(201, 36);
            this.enterTB.Name = "enterTB";
            this.enterTB.Size = new System.Drawing.Size(145, 25);
            this.enterTB.TabIndex = 6;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(374, 32);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(93, 33);
            this.checkBtn.TabIndex = 7;
            this.checkBtn.Text = "查询";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(168, 104);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(129, 64);
            this.delBtn.TabIndex = 9;
            this.delBtn.Text = "删除订单";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // changeOrder
            // 
            this.changeOrder.Location = new System.Drawing.Point(314, 104);
            this.changeOrder.Name = "changeOrder";
            this.changeOrder.Size = new System.Drawing.Size(129, 64);
            this.changeOrder.TabIndex = 11;
            this.changeOrder.Text = "修改订单";
            this.changeOrder.UseVisualStyleBackColor = true;
            this.changeOrder.Click += new System.EventHandler(this.changeOrder_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(461, 104);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(129, 64);
            this.exportBtn.TabIndex = 13;
            this.exportBtn.Text = "导出订单";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(607, 104);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(129, 64);
            this.importBtn.TabIndex = 14;
            this.importBtn.Text = "导入订单";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sortCbx
            // 
            this.sortCbx.FormattingEnabled = true;
            this.sortCbx.ItemHeight = 15;
            this.sortCbx.Items.AddRange(new object[] {
            "ID",
            "创建时间",
            "总金额",
            "订单明细数"});
            this.sortCbx.Location = new System.Drawing.Point(543, 48);
            this.sortCbx.Name = "sortCbx";
            this.sortCbx.Size = new System.Drawing.Size(149, 23);
            this.sortCbx.TabIndex = 15;
            this.sortCbx.SelectedIndexChanged += new System.EventHandler(this.sortCbx_SelectedIndexChanged);
            // 
            // sortBtn
            // 
            this.sortBtn.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sortBtn.Location = new System.Drawing.Point(698, 33);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(38, 42);
            this.sortBtn.TabIndex = 16;
            this.sortBtn.Text = "⬇";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // osPanel
            // 
            this.osPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.osPanel.Controls.Add(this.label2);
            this.osPanel.Controls.Add(this.comboBox1);
            this.osPanel.Controls.Add(this.importBtn);
            this.osPanel.Controls.Add(this.sortBtn);
            this.osPanel.Controls.Add(this.exportBtn);
            this.osPanel.Controls.Add(this.enterTB);
            this.osPanel.Controls.Add(this.changeOrder);
            this.osPanel.Controls.Add(this.sortCbx);
            this.osPanel.Controls.Add(this.delBtn);
            this.osPanel.Controls.Add(this.checkBtn);
            this.osPanel.Controls.Add(this.addOrder);
            this.osPanel.Location = new System.Drawing.Point(30, 12);
            this.osPanel.Name = "osPanel";
            this.osPanel.Size = new System.Drawing.Size(748, 188);
            this.osPanel.TabIndex = 17;
            this.osPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(596, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "排序";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "操作栏";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "货物名";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderServiceBindingSource
            // 
            this.orderServiceBindingSource.DataSource = typeof(winFormOS.Order);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "客户名";
            this.customerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "总金额";
            this.totalAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalAmountDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.osPanel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OrderListGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OrderListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.osPanel.ResumeLayout(false);
            this.osPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderServiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.DataGridView OrderListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailsDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource orderServiceBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commoditDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox enterTB;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button changeOrder;
        public System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox sortCbx;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Panel osPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
    }
}

