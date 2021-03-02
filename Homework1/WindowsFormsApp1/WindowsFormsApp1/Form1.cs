using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int firstNum;
        int secondNum;
        int choice;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            firstNum = int.Parse("0"+textBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            choice = int.Parse(comboBox1.SelectedIndex.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.Items.Add("%");
            label1.Text = "0";
            label2.Text = "数字";
            label3.Text = "下拉选择运算符";
            label4.Text = "数字";
            button1.Text = "运算";
            label5.Text = "结果:";
            textBox1.Text = "0";
            textBox2.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = 0;
            bool flag = true;
            switch (choice) {
                case 0:
                    result = firstNum + secondNum;
                    break;
                case 1:
                    result = firstNum - secondNum;
                    break;
                case 2:
                    result = firstNum * secondNum;
                    
                    break;
                case 3:
                    if (secondNum != 0)
                        result = firstNum / secondNum;
                    else
                        flag = false;
                    break;
                case 4:
                    result = firstNum % secondNum;
                    break;
            }                Console.WriteLine(result);
            if (flag)
                label1.Text = result.ToString();
            else
                label1.Text = "Wrong number!";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            secondNum = int.Parse("0"+textBox2.Text);
        }

        
    }
}
