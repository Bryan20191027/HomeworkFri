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
    public partial class Form2 : Form
    {
        public Order order = new Order();
        public OrderDetail od = new OrderDetail();

        public Form2(Order order,OrderDetail odt)
        {
            InitializeComponent();
            OrderIDTB.DataBindings.Add("Text", order, "OrderId");
            CustomerNameTB.DataBindings.Add("Text", order.customer, "Name");
            CustomerAddressTB.DataBindings.Add("Text", order.customer, "Address");
            CommoditNameTB.DataBindings.Add("Text", odt, "Name");
            CommoditUnitpriceTB.DataBindings.Add("Text", odt, "UnitPrice");
            QuantityTB.DataBindings.Add("Text", odt, "Quantity");
            this.order = order;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.Owner;
            
            if (form1.os.checkID(order.OrderID))
            {
                order = Order.createOrder(order.OrderID.ToString(), order.customer.Name, order.customer.Address, 
                    order.orderDetails[0].Name, order.orderDetails[0].UnitPrice, order.orderDetails[0].Quantity);
                form1.os.addOrder(order);
                form1.os.list.Sort((o1, o2) => (int)(o1.OrderID - o2.OrderID));
                form1.orderServiceBindingSource.ResetBindings(false);
                this.Close();
            }
            else
            {
                MessageBox.Show("索引发生了重复", "索引重复警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void CustomerAddressTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
