using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winFormOS
{
    public partial class Form1 : Form
    {
        public OrderService os= new OrderService();
        public Form1()
        {
            InitializeComponent();
            sortBtn.Text = "⬆";
            sortCbx.SelectedIndex = 0;
            os.addOrder(Order.createOrder("1", "Tom", "xxx", "xxx", 20, 20));
            os.list[0].addOrderItem("xxx", 30, 20);
            os.addOrder(Order.createOrder("3", "Tom", "xxx", "xxx", 20, 20));
            os.addOrder(Order.createOrder("4", "Tom", "xxx", "xxx", 20, 20));
            os.addOrder(Order.createOrder("5", "Tom", "xxx", "xxx", 20, 20));
            os.addOrder(Order.createOrder("6", "Tom", "xxx", "xxx", 20, 20));
            os.addOrder(Order.createOrder("7", "Tom", "xxx", "xxx", 20, 20));
            os.addOrder(Order.createOrder("8", "Tom", "xxx", "xxx", 20, 20));
            Order tempOrder1 = Order.createOrder("9", "Tom1", "xxx11", "xxx11", 21, 201);
            Order tempOrder = Order.createOrder("9", "Tom111111", "xxx11", "xxx11", 201, 201);
            os.addOrder(tempOrder);
            if (os.list != null)
            {
                orderServiceBindingSource.DataSource = os.list;
                OrderListGrid.DataSource = orderServiceBindingSource;
            }
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            Order od = new Order();
            od.customer = new Customer();
            od.orderDetails = new List<OrderDetail>();
            OrderDetail tempOdt = new OrderDetail();
            od.orderDetails.Add(tempOdt);
            Form2 form2 = new Form2(od,tempOdt);
            form2.Show(this);
        }

        private void orderServiceBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            int checkCol = comboBox1.SelectedIndex == 0 ? 0 : 2;
            string value = enterTB.Text;
            int row = OrderListGrid.Rows.Count;
            for (int i = 0; i < row; i++)
                if (OrderListGrid.Rows[i].Cells[checkCol].Value!=null&&value == OrderListGrid.Rows[i].Cells[checkCol].Value.ToString())
                    OrderListGrid.Rows[i].Cells[0].Selected = true;

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            List<string> selectedID = new List<string>();
            if (OrderListGrid.SelectedRows != null)
            {
                for(int i = 0;i< OrderListGrid.SelectedRows.Count; i++)
                {
                    selectedID.Add(OrderListGrid.SelectedRows[i].Cells[0].Value.ToString());
                }
            }
            os.deleteOrder(selectedID);
            orderServiceBindingSource.ResetBindings(false);
        }

        private void changeOrder_Click(object sender, EventArgs e)
        {
            long tempID = long.Parse(OrderListGrid.CurrentRow.Cells[0].Value.ToString());
            int index = -1;
            for(int i = 0; i < os.list.Count; i++)
            {
                if(os.list[i].OrderID == tempID)
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                Form3 form3 = new Form3(index,os.list[index]);
                form3.Show(this);
            }
        }


        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = this.folderBrowserDialog1.SelectedPath;
                os.Export(path);
            }

        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = this.openFileDialog1.FileName;
                os.Import(path);
                os.list.Sort((o1,o2)=>(int)(o1.OrderID-o2.OrderID));
                orderServiceBindingSource.ResetBindings(false);
                orderDetailsBindingSource.ResetBindings(false);
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (sortBtn.Text == "⬆")
                sortBtn.Text = "⬇";
            else
                sortBtn.Text = "⬆";
            os.list.Reverse();
            orderServiceBindingSource.ResetBindings(false);
            orderDetailsBindingSource.ResetBindings(false);
        }

        private void sortCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = sortCbx.SelectedIndex;
            os.sortOrder(index);
            orderServiceBindingSource.ResetBindings(false);
            orderDetailsBindingSource.ResetBindings(false);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
