namespace winFormOS
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderDetailView = new System.Windows.Forms.DataGridView();
            this.addDetailBtn = new System.Windows.Forms.Button();
            this.changeDetailBtn = new System.Windows.Forms.Button();
            this.delDetailBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDInput = new System.Windows.Forms.TextBox();
            this.customerNameInput = new System.Windows.Forms.TextBox();
            this.customerAddressInput = new System.Windows.Forms.TextBox();
            this.totalAmountLB = new System.Windows.Forms.Label();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detailIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDetailView
            // 
            this.orderDetailView.AutoGenerateColumns = false;
            this.orderDetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailIndex,
            this.nameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.orderDetailView.DataSource = this.orderDetailBindingSource;
            this.orderDetailView.Location = new System.Drawing.Point(74, 113);
            this.orderDetailView.Name = "orderDetailView";
            this.orderDetailView.RowHeadersWidth = 51;
            this.orderDetailView.RowTemplate.Height = 27;
            this.orderDetailView.Size = new System.Drawing.Size(687, 272);
            this.orderDetailView.TabIndex = 0;
            this.orderDetailView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.orderDetailView_RowPostPaint);
            // 
            // addDetailBtn
            // 
            this.addDetailBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addDetailBtn.Location = new System.Drawing.Point(24, 15);
            this.addDetailBtn.Name = "addDetailBtn";
            this.addDetailBtn.Size = new System.Drawing.Size(152, 46);
            this.addDetailBtn.TabIndex = 1;
            this.addDetailBtn.Text = "添加空白明细";
            this.addDetailBtn.UseVisualStyleBackColor = true;
            this.addDetailBtn.Click += new System.EventHandler(this.addDetailBtn_Click);
            // 
            // changeDetailBtn
            // 
            this.changeDetailBtn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.changeDetailBtn.Location = new System.Drawing.Point(196, 15);
            this.changeDetailBtn.Name = "changeDetailBtn";
            this.changeDetailBtn.Size = new System.Drawing.Size(116, 46);
            this.changeDetailBtn.TabIndex = 2;
            this.changeDetailBtn.Text = "修改明细";
            this.changeDetailBtn.UseVisualStyleBackColor = true;
            this.changeDetailBtn.Click += new System.EventHandler(this.changeDetailBtn_Click);
            // 
            // delDetailBtn
            // 
            this.delDetailBtn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.delDetailBtn.Location = new System.Drawing.Point(334, 15);
            this.delDetailBtn.Name = "delDetailBtn";
            this.delDetailBtn.Size = new System.Drawing.Size(114, 46);
            this.delDetailBtn.TabIndex = 3;
            this.delDetailBtn.Text = "删除明细";
            this.delDetailBtn.UseVisualStyleBackColor = true;
            this.delDetailBtn.Click += new System.EventHandler(this.delDetailBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.saveBtn.Location = new System.Drawing.Point(582, 39);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(118, 46);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "保存订单";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addDetailBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.changeDetailBtn);
            this.panel1.Controls.Add(this.delDetailBtn);
            this.panel1.Location = new System.Drawing.Point(60, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 93);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.totalAmountLB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.customerAddressInput);
            this.panel2.Controls.Add(this.customerNameInput);
            this.panel2.Controls.Add(this.IDInput);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(65, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 75);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "客户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "客户地址";
            // 
            // IDInput
            // 
            this.IDInput.Location = new System.Drawing.Point(67, 16);
            this.IDInput.Name = "IDInput";
            this.IDInput.Size = new System.Drawing.Size(105, 25);
            this.IDInput.TabIndex = 6;
            // 
            // customerNameInput
            // 
            this.customerNameInput.Location = new System.Drawing.Point(263, 16);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.Size = new System.Drawing.Size(83, 25);
            this.customerNameInput.TabIndex = 7;
            // 
            // customerAddressInput
            // 
            this.customerAddressInput.Location = new System.Drawing.Point(462, 17);
            this.customerAddressInput.Name = "customerAddressInput";
            this.customerAddressInput.Size = new System.Drawing.Size(100, 25);
            this.customerAddressInput.TabIndex = 8;
            // 
            // totalAmountLB
            // 
            this.totalAmountLB.AutoSize = true;
            this.totalAmountLB.Location = new System.Drawing.Point(641, 19);
            this.totalAmountLB.Name = "totalAmountLB";
            this.totalAmountLB.Size = new System.Drawing.Size(55, 15);
            this.totalAmountLB.TabIndex = 9;
            this.totalAmountLB.Text = "label2";
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(winFormOS.OrderDetail);
            // 
            // OrderBindingSource
            // 
            this.OrderBindingSource.DataSource = typeof(winFormOS.Order);
            // 
            // detailIndex
            // 
            this.detailIndex.DataPropertyName = "Index";
            this.detailIndex.HeaderText = "索引";
            this.detailIndex.MinimumWidth = 6;
            this.detailIndex.Name = "detailIndex";
            this.detailIndex.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "数量";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "totalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总金额";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "总金额：";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderDetailView);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderDetailView;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.Button addDetailBtn;
        private System.Windows.Forms.Button changeDetailBtn;
        private System.Windows.Forms.Button delDetailBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerAddressInput;
        private System.Windows.Forms.TextBox customerNameInput;
        private System.Windows.Forms.TextBox IDInput;
        private System.Windows.Forms.Label totalAmountLB;
        private System.Windows.Forms.BindingSource OrderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}