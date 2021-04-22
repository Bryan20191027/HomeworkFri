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
    public partial class Form3 : Form
    {
        public Order changeOrder = new Order();
        public int index;
        public long saveID;
        public Form3(int index,Order tempOrder)
        {
            InitializeComponent();
            //od = tempOrder;
            changeOrder=Order.copyOrder(tempOrder);
            saveID = tempOrder.OrderID;
            //label1.Text = changeOrder.orderDetails[0].totalPrice.ToString();
            this.index = index;
            if (changeOrder.orderDetails != null)
            {
                orderDetailBindingSource.DataSource = changeOrder.orderDetails;
                orderDetailView.DataSource = orderDetailBindingSource;
            }
            IDInput.DataBindings.Add("Text", OrderBindingSource, "OrderID");
            customerNameInput.DataBindings.Add("Text", OrderBindingSource, "customer.Name");
            customerAddressInput.DataBindings.Add("Text", OrderBindingSource, "customer.Address");
            totalAmountLB.DataBindings.Add("Text", OrderBindingSource, "TotalAmount");
            OrderBindingSource.DataSource = changeOrder;
        }

        private void addDetailBtn_Click(object sender, EventArgs e)
        {
            changeOrder.addOrderItem(" ",0,0);
            orderDetailBindingSource.ResetBindings(false);
        }

        private void changeDetailBtn_Click(object sender, EventArgs e)
        {
            changeOrder.TotalAmount = 0;
            for(int i = 0; i < orderDetailView.Rows.Count-1; i++)
            {
                changeOrder.orderDetails[i].Name = orderDetailView.Rows[i].Cells[1].Value.ToString();
                changeOrder.orderDetails[i].UnitPrice = double.Parse(orderDetailView.Rows[i].Cells[2].Value.ToString());
                changeOrder.orderDetails[i].Quantity = int.Parse(orderDetailView.Rows[i].Cells[3].Value.ToString());
                changeOrder.orderDetails[i].totalPrice = changeOrder.orderDetails[i].UnitPrice * changeOrder.orderDetails[i].Quantity;
                changeOrder.TotalAmount += changeOrder.orderDetails[i].totalPrice;
            }
            changeOrder.Time = DateTime.Now.ToString();
            orderDetailBindingSource.ResetBindings(false);
            OrderBindingSource.ResetBindings(false);
        }

        private void delDetailBtn_Click(object sender, EventArgs e)
        {
            int index = orderDetailView.CurrentCell.RowIndex;
            changeOrder.orderDetails.RemoveAt(index);
            orderDetailBindingSource.ResetBindings(false);
            OrderBindingSource.ResetBindings(false);
        }


        private void orderDetailView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (DataGridViewRow row in orderDetailView.Rows)
            {
                row.Cells[0].Value = row.Index + 1;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            Boolean flag = true;
            if (changeOrder.OrderID != saveID)
            {
                foreach (Order od in form1.os.list)
                {
                    if (od.OrderID == changeOrder.OrderID)
                    {
                        flag = false;
                        break;
                    }
                }
                if (!flag)
                    MessageBox.Show("索引发生了重复", "索引重复警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(flag)
            {
                form1.os.list[index] = changeOrder;
                form1.os.sortOrder(0);
                this.Close();
                form1.orderServiceBindingSource.ResetBindings(false);
                form1.orderDetailsBindingSource.ResetBindings(false);
            }
        }
    }
}