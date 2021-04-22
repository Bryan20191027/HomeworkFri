using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace winFormOS
{
    [Serializable]
    public class Order
    {
        public long OrderID { get; set; }

        public string Time { get; set; }
        public Customer customer { get; set; }
        public double TotalAmount { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
        public override bool Equals(Object obj)
        {
            Order m = obj as Order;
            return (m != null) && (m.OrderID == OrderID);
        }

        public static Order copyOrder(Order tempOrder)
        {
            Order newOrder = new Order();
            newOrder.Time = tempOrder.Time;
            newOrder.customer = new Customer();
            newOrder.orderDetails = new List<OrderDetail>();
            newOrder.TotalAmount = tempOrder.TotalAmount;
            newOrder.OrderID = tempOrder.OrderID;
            newOrder.customer.Name = tempOrder.customer.Name;
            newOrder.customer.Address = tempOrder.customer.Address;
            List<OrderDetail> odts = new List<OrderDetail>();
            for(int i = 0;i<tempOrder.orderDetails.Count;i++){
                OrderDetail odt = new OrderDetail();
                odt.Name = tempOrder.orderDetails[i].Name;
                odt.Quantity = tempOrder.orderDetails[i].Quantity;
                odt.UnitPrice = tempOrder.orderDetails[i].UnitPrice;
                odt.totalPrice = tempOrder.orderDetails[i].totalPrice;
                odts.Add(odt);
            }
            newOrder.orderDetails = odts;
            return newOrder;
        }


        public override string ToString()
        {
            return "订单ID：" + OrderID + " " + customer.ToString() + " 总金额：" + TotalAmount + " " + orderDetails.ToString();
        }

        public static Order createOrder(string tempID, string customerName, string address, string commoditName, double unitPrice, int amount)
        {
            Order tempOrder = new Order();
            tempOrder.OrderID = long.Parse(tempID);
            tempOrder.customer = new Customer(customerName, address);
            List<OrderDetail> ods = new List<OrderDetail>();
            ods.Add(new OrderDetail(commoditName, unitPrice, amount));
            tempOrder.orderDetails = ods;
            tempOrder.TotalAmount = (int)(amount * unitPrice);
            tempOrder.Time = DateTime.Now.ToString();
            return tempOrder;
        }

        public void addOrderItem(string commoditName, double unitPrice, int amount)
        {
            orderDetails.Add(new OrderDetail(commoditName, unitPrice, amount));
            TotalAmount += unitPrice * amount;
        }

        public void addOrderItem(OrderDetail odt)
        {
            orderDetails.Add(odt);
            TotalAmount += odt.totalPrice;
        }

        public override int GetHashCode()
        {
            int hashCode = 538387531;
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(customer);
            hashCode = hashCode * -1521134295 + TotalAmount.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetail>>.Default.GetHashCode(orderDetails);
            return hashCode;
        }
    }
    [Serializable]
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Customer()
        {

        }
        public Customer(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    [Serializable]
    public class OrderDetail
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double totalPrice { get; set; }
        public override bool Equals(Object obj)
        {
            OrderDetail m = obj as OrderDetail;
            return m != null && m.Quantity == Quantity;
        }

        public override int GetHashCode()
        {
            int hashCode = -1692427010;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + UnitPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }

        public OrderDetail(string name, double unitPrice, int Quantity)
        {
            this.Name = name;
            this.UnitPrice = unitPrice;
            this.Quantity = Quantity;
            this.totalPrice = unitPrice * Quantity;
        }

        public OrderDetail()
        {

        }

    }

    class tempException : ApplicationException
    {
        public tempException(string message) : base(message)
        {
        }
    }
    [Serializable]
    public class OrderService
    {
        public List<Order> list = new List<Order>();

        public List<Order> listGet()
        {
            return list;
        }

        public Boolean checkID(long tempID)
        {
            Boolean flag = true;
            foreach(Order od in list)
            {
                if(od.OrderID == tempID)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        public void addOrder(Order tempOrder)
        {
            try
            {
                bool flag = true;
                foreach (Order od in list)
                {
                    if (od.Equals(tempOrder))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    list.Add(tempOrder);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Wrong Enter!");
            }
        }

        public void deleteOrder(List<string> strList)
        {
            Boolean flagDel = false;
            for(int i = 0; i < list.Count;)
            {
                for(int j = 0; j < strList.Count; j++)
                {
                    if (list[i].OrderID == long.Parse(strList[j]))
                    {
                        flagDel = true;
                        break;
                    }
                }
                if (flagDel)
                {
                    list.RemoveAt(i);
                    flagDel = false;
                }
                else
                    i++;
            }

        }

        public void changeOrder(List<Order> tempList)
        {
           
        }



        public List<Order> checkOrder()
        {
            return null;
        }

        public void sortOrder(int select)
        {
            switch (select)
            {
                case 0:
                    list.Sort((o1, o2) => (int)(o1.OrderID - o2.OrderID));
                    break;
                case 1:
                    list.Sort((o1, o2) => (int)(long.Parse(new DateTimeOffset(DateTime.Parse(o1.Time)).ToUnixTimeSeconds().ToString())
                        - long.Parse(new DateTimeOffset(DateTime.Parse(o1.Time)).ToUnixTimeSeconds().ToString())));
                    break;
                case 2:
                    list.Sort((o1, o2) => (int)(o1.TotalAmount-o2.TotalAmount));
                    break;
                case 3:
                    list.Sort((o1, o2) => o1.orderDetails.Count-o2.orderDetails.Count);
                    break;
            }
        }

        public void Export(string path)
        {
            Order[] orders = new Order[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                orders[i] = list[i];
            }
            XmlSerializer xmlTemp = new XmlSerializer(typeof(Order[]));
            using (FileStream fs = new FileStream(path + "//OrderListTemp.xml", FileMode.Create))
            {
                xmlTemp.Serialize(fs, orders);
            }
        }

        public void Import(string path)
        {
            if (!File.Exists(path) || !path.EndsWith(".xml"))
            {
                
            }
            List<Order> tempOrder = new List<Order>();
            Order[] orders;
            XmlSerializer xmlTemp = new XmlSerializer(typeof(Order[]));
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    orders = (Order[])xmlTemp.Deserialize(fs);
                }
                foreach (Order od in orders)
                {
                    addOrder(od);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

