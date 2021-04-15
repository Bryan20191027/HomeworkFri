using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Color color = Color.Black;

        public Form1()
        {
            this.BackColor = Color.White;
            InitializeComponent();
            color = label7.BackColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(recursioN.Text);
            double leng = double.Parse(length.Text);
            if (graphics == null) graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            drawCayleyTree(n, 200, 310, leng, -Math.PI / 2);
        }

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n <= 0) return;
            if (leng <= 0) return;
            double th1 = rightAn.Value * Math.PI / 180;
            double th2 = leftAn.Value * Math.PI / 180;
            if (th1 <= 0 || th2 <= 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, (double)rightTB.Value / 100 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, (double)leftTB.Value / 100 * leng, th - th2);
        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(new Pen(color), (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rightTB.Maximum = 99;
            rightTB.Minimum = 1;
            leftTB.Maximum = 99;
            leftTB.Minimum = 1;
            rightAn.Minimum = 0;
            leftAn.Minimum = 0;
            rightAn.Maximum = 180;
            leftAn.Maximum = 180;
        }

        private void rightTB_Scroll(object sender, EventArgs e)
        {
            
            rightTBV.Text = ((double)rightTB.Value/100).ToString();
        }

        private void leftTB_Scroll(object sender, EventArgs e)
        {
            leftTBV.Text = ((double)leftTB.Value / 100).ToString();
        }

        private void leftAn_Scroll(object sender, EventArgs e)
        {
            leftAnL.Text = ((double)leftAn.Value).ToString() + "度";
        }

        private void rightAn_Scroll(object sender, EventArgs e)
        {
            rightAnL.Text = ((double)rightAn.Value).ToString() + "度";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = this.colorDialog1.Color;
                label7.BackColor = color;
            }
        }
    }
}
