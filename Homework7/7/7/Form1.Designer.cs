namespace _7
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
            this.button1 = new System.Windows.Forms.Button();
            this.recursioN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rightTB = new System.Windows.Forms.TrackBar();
            this.leftTB = new System.Windows.Forms.TrackBar();
            this.rightTBV = new System.Windows.Forms.Label();
            this.leftTBV = new System.Windows.Forms.Label();
            this.rightAn = new System.Windows.Forms.TrackBar();
            this.leftAn = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rightAnL = new System.Windows.Forms.Label();
            this.leftAnL = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.rightTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftAn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // recursioN
            // 
            this.recursioN.Location = new System.Drawing.Point(117, 18);
            this.recursioN.Name = "recursioN";
            this.recursioN.Size = new System.Drawing.Size(100, 25);
            this.recursioN.TabIndex = 1;
            this.recursioN.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "递归深度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "主干长度";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(117, 63);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(100, 25);
            this.length.TabIndex = 4;
            this.length.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "右分支长度比";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "左分支长度比";
            // 
            // rightTB
            // 
            this.rightTB.Location = new System.Drawing.Point(133, 94);
            this.rightTB.Name = "rightTB";
            this.rightTB.Size = new System.Drawing.Size(104, 56);
            this.rightTB.TabIndex = 7;
            this.rightTB.Scroll += new System.EventHandler(this.rightTB_Scroll);
            // 
            // leftTB
            // 
            this.leftTB.Location = new System.Drawing.Point(133, 156);
            this.leftTB.Name = "leftTB";
            this.leftTB.Size = new System.Drawing.Size(104, 56);
            this.leftTB.TabIndex = 8;
            this.leftTB.Scroll += new System.EventHandler(this.leftTB_Scroll);
            // 
            // rightTBV
            // 
            this.rightTBV.AutoSize = true;
            this.rightTBV.Location = new System.Drawing.Point(740, 116);
            this.rightTBV.Name = "rightTBV";
            this.rightTBV.Size = new System.Drawing.Size(0, 15);
            this.rightTBV.TabIndex = 9;
            // 
            // leftTBV
            // 
            this.leftTBV.AutoSize = true;
            this.leftTBV.Location = new System.Drawing.Point(739, 160);
            this.leftTBV.Name = "leftTBV";
            this.leftTBV.Size = new System.Drawing.Size(0, 15);
            this.leftTBV.TabIndex = 10;
            // 
            // rightAn
            // 
            this.rightAn.Location = new System.Drawing.Point(133, 211);
            this.rightAn.Name = "rightAn";
            this.rightAn.Size = new System.Drawing.Size(99, 56);
            this.rightAn.TabIndex = 11;
            this.rightAn.Scroll += new System.EventHandler(this.rightAn_Scroll);
            // 
            // leftAn
            // 
            this.leftAn.Location = new System.Drawing.Point(129, 262);
            this.leftAn.Name = "leftAn";
            this.leftAn.Size = new System.Drawing.Size(103, 56);
            this.leftAn.TabIndex = 12;
            this.leftAn.Scroll += new System.EventHandler(this.leftAn_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "右分支角度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "左分支角度";
            // 
            // rightAnL
            // 
            this.rightAnL.AutoSize = true;
            this.rightAnL.Location = new System.Drawing.Point(747, 219);
            this.rightAnL.Name = "rightAnL";
            this.rightAnL.Size = new System.Drawing.Size(0, 15);
            this.rightAnL.TabIndex = 15;
            // 
            // leftAnL
            // 
            this.leftAnL.AutoSize = true;
            this.leftAnL.Location = new System.Drawing.Point(750, 261);
            this.leftAnL.Name = "leftAnL";
            this.leftAnL.Size = new System.Drawing.Size(0, 15);
            this.leftAnL.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 49);
            this.button2.TabIndex = 17;
            this.button2.Text = "选择颜色";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(47, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 50);
            this.label7.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.recursioN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.length);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.leftAn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rightTB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rightAn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.leftTB);
            this.panel1.Location = new System.Drawing.Point(536, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 426);
            this.panel1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftAnL);
            this.Controls.Add(this.rightAnL);
            this.Controls.Add(this.leftTBV);
            this.Controls.Add(this.rightTBV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rightTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftAn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox recursioN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar rightTB;
        private System.Windows.Forms.TrackBar leftTB;
        private System.Windows.Forms.Label rightTBV;
        private System.Windows.Forms.Label leftTBV;
        private System.Windows.Forms.TrackBar rightAn;
        private System.Windows.Forms.TrackBar leftAn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rightAnL;
        private System.Windows.Forms.Label leftAnL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}

