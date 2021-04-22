namespace winFormOS
{
    partial class Form2
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
            this.OrderIDTB = new System.Windows.Forms.TextBox();
            this.CustomerNameTB = new System.Windows.Forms.TextBox();
            this.CustomerAddressTB = new System.Windows.Forms.TextBox();
            this.CommoditNameTB = new System.Windows.Forms.TextBox();
            this.CommoditUnitpriceTB = new System.Windows.Forms.TextBox();
            this.QuantityTB = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderIDTB
            // 
            this.OrderIDTB.Location = new System.Drawing.Point(83, 80);
            this.OrderIDTB.Name = "OrderIDTB";
            this.OrderIDTB.Size = new System.Drawing.Size(181, 25);
            this.OrderIDTB.TabIndex = 0;
            // 
            // CustomerNameTB
            // 
            this.CustomerNameTB.Location = new System.Drawing.Point(408, 80);
            this.CustomerNameTB.Name = "CustomerNameTB";
            this.CustomerNameTB.Size = new System.Drawing.Size(181, 25);
            this.CustomerNameTB.TabIndex = 1;
            // 
            // CustomerAddressTB
            // 
            this.CustomerAddressTB.Location = new System.Drawing.Point(83, 162);
            this.CustomerAddressTB.Name = "CustomerAddressTB";
            this.CustomerAddressTB.Size = new System.Drawing.Size(181, 25);
            this.CustomerAddressTB.TabIndex = 2;
            this.CustomerAddressTB.TextChanged += new System.EventHandler(this.CustomerAddressTB_TextChanged);
            // 
            // CommoditNameTB
            // 
            this.CommoditNameTB.Location = new System.Drawing.Point(408, 162);
            this.CommoditNameTB.Name = "CommoditNameTB";
            this.CommoditNameTB.Size = new System.Drawing.Size(181, 25);
            this.CommoditNameTB.TabIndex = 3;
            // 
            // CommoditUnitpriceTB
            // 
            this.CommoditUnitpriceTB.Location = new System.Drawing.Point(86, 239);
            this.CommoditUnitpriceTB.Name = "CommoditUnitpriceTB";
            this.CommoditUnitpriceTB.Size = new System.Drawing.Size(181, 25);
            this.CommoditUnitpriceTB.TabIndex = 4;
            // 
            // QuantityTB
            // 
            this.QuantityTB.Location = new System.Drawing.Point(408, 236);
            this.QuantityTB.Name = "QuantityTB";
            this.QuantityTB.Size = new System.Drawing.Size(181, 25);
            this.QuantityTB.TabIndex = 5;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmButton.Location = new System.Drawing.Point(301, 358);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 50);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "创建";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(80, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "订单号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label2.Location = new System.Drawing.Point(411, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "客户名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label3.Location = new System.Drawing.Point(83, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "客户地址";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label4.Location = new System.Drawing.Point(411, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "货物名";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label5.Location = new System.Drawing.Point(83, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "货物单价";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label6.Location = new System.Drawing.Point(411, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "货物数量";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.QuantityTB);
            this.Controls.Add(this.CommoditUnitpriceTB);
            this.Controls.Add(this.CommoditNameTB);
            this.Controls.Add(this.CustomerAddressTB);
            this.Controls.Add(this.CustomerNameTB);
            this.Controls.Add(this.OrderIDTB);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OrderIDTB;
        private System.Windows.Forms.TextBox CustomerNameTB;
        private System.Windows.Forms.TextBox CustomerAddressTB;
        private System.Windows.Forms.TextBox CommoditNameTB;
        private System.Windows.Forms.TextBox CommoditUnitpriceTB;
        private System.Windows.Forms.TextBox QuantityTB;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}