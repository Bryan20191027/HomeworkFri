using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormRe
{
    public partial class Form1 : Form
    {
        public SimpleCrawler myCrawler = new SimpleCrawler();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = urlPBindingSource;
            textBox1.Text = "http://www.cnblogs.com/dstang2000/";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = myCrawler.urList.Count.ToString();
            urlPBindingSource.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            urlPBindingSource.Clear();
            myCrawler = new SimpleCrawler();
            urlPBindingSource.DataSource = myCrawler.urList;
            string startUrl = textBox1.Text;
            myCrawler.urList.Add(new UrlP(startUrl, false,true));//加入初始页面
            Thread s = new Thread(myCrawler.Crawl);
            s.Start();
            while (s.IsAlive)
            {
                urlPBindingSource.ResetBindings(false);
            }
        }

        private void urlPBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
