using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderSpace
{
    [Serializable]
    public class Order
    {
        public long OrderID { get; set; }
        public Customer customer { get; set; }
        public int TotalAmount { get; set; }
        public OrderDetails orderDetails { get; set; }
        public override bool Equals(Object obj)
        {
            Order m = obj as Order;
            return m != null && m.OrderID == OrderID && (m.orderDetails.Equals(orderDetails))&&m.orderDetails!=null;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(OrderID, customer, TotalAmount, orderDetails);
        }

        public override string ToString()
        {
            return "订单ID：" + OrderID + " " + customer.ToString() + " 总金额：" + TotalAmount + " " + orderDetails.ToString();
        }

        public static Order createOrder(string tempID,string customerName,string address,string commoditName,double unitPrice,int amount)
        {
            Order tempOrder = new Order();
            tempOrder.OrderID = long.Parse(new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString() + tempID);
            tempOrder.customer = new Customer(customerName,address);
            tempOrder.orderDetails = new OrderDetails(commoditName,unitPrice,amount);
            tempOrder.TotalAmount = (int)(amount * unitPrice);
            return tempOrder;
        }
    }
    [Serializable]
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Time { get; set; }
        public Customer()
        {
            this.Time = DateTime.Now.ToString();
        }
        public Customer(string Name,string Address)
        {
            this.Time = DateTime.Now.ToString();
            this.Name = Name;
            this.Address = Address;
        }

        public override string ToString()
        {
            return "客户名字：" + Name + " 收货地址：" + Address + " 下单时间：" + Time;
        }
    }
    [Serializable]
    public class OrderDetails
    {
        public Commodit commodit{ get; set; }       
        public int Quantity { get; set; }
        public override bool Equals(Object obj)
        {
            OrderDetails m = obj as OrderDetails;
            return m != null && m.Quantity == Quantity;
        }

        public OrderDetails(string name,double unitPrice,int Quantity)
        {
            commodit = new Commodit(name, unitPrice);
            this.Quantity = Quantity;
        }

        public OrderDetails()
        {

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(commodit, Quantity);
        }

        public override string ToString()
        {
            return commodit.ToString() + " 数量：" + Quantity;
        }
    }
    [Serializable]
    public class Commodit
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }

        public override string ToString()
        {
            return "货物种类："+Name+" 货物单价：" + UnitPrice;
        }
        public Commodit(string Name,double unitPrice)
        {
            this.Name = Name;
            this.UnitPrice = unitPrice;
        }

        public Commodit()
        {

        }
    }

    class tempException : ApplicationException
    {
        public tempException(string message):base(message)
        {
        }
    }
    [Serializable]
    public class OrderService
    {
        List<Order> list = new List<Order>();

        public List<Order> listGet()
        {
            return list;
        }

        public void beginService()
        {
            int select;
            while (true)
            {
                Console.Write("1.添加订单 2.删除订单 3.修改订单 4.查询订单 5.输出所有订单 6.序列化订单 7.反序列化订单文件 8.排序订单 0.退出 输入使用功能：");
                select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.Write("订单ID：");
                        string tempOrderID = Console.ReadLine();
                        Console.Write("客户名：");
                        string customerName = Console.ReadLine();
                        Console.Write("配送地址：");
                        string customerAddress = Console.ReadLine();
                        Console.Write("货物种类：");
                        string commoditName = Console.ReadLine();
                        Console.Write("货物单价：");
                        double UnitPrice = double.Parse(Console.ReadLine());
                        Console.Write("数量:");
                        int Quantity = int.Parse(Console.ReadLine());
                        Order tempOrder = Order.createOrder(tempOrderID, customerName, customerAddress, commoditName, UnitPrice, Quantity);
                        addOrder(tempOrder);
                        break;
                    case 2:
                        deleteOrder(checkOrder());
                        break;
                    case 3:
                        changeOrder(checkOrder());
                        break;
                    case 4:
                        printOrder(checkOrder());
                        break;
                    case 5:
                        printOrder(list);
                        break;
                    case 6:
                        Console.Write("输入输出路径：");
                        Export(Console.ReadLine());
                        break;
                    case 7:
                        Console.Write("输入XML文件路径：");
                        Import(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("排序：1.ID 2.总金额 3.单价 4.数量");
                        int selectSort = int.Parse(Console.ReadLine());
                        sortOrder(selectSort);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Wrong Enter!");
                        break;
                }
                if (select == 0)
                    break;
            }
        }

        public void addOrder(Order tempOrder)
        {
            try
            {
                bool flag = true;  
                foreach (Order od in list)
                {
                    if (od.Equals(tempOrder))
                        flag = false;
                }
                if (flag)
                    list.Add(tempOrder);
            }
            catch(IOException e)
            {
                Console.WriteLine(e);
                Console.WriteLine("Wrong Enter!");
            }
        }

        public void deleteOrder(List<Order> tempList)
        {
            bool flag = true;
            for(int i = 0; i < tempList.Count; i++)
            {
                for(int j = 0; j <list.Count; j++)
                {
                    if (list[j].OrderID == tempList[i].OrderID)
                    {
                        list.RemoveAt(j);
                        flag = false;
                    }
                }
            }
            if (flag)
            {
                throw new tempException("找不到对应订单");
            }
        }

        public void changeOrder(List<Order> tempList)
        {
            bool flag = true;
            int[] index = new int[list.Count];
            int select;
            foreach (Order o in list)
            {
                foreach (Order ord in list)
                {
                    if (ord.OrderID == o.OrderID)
                    {
                        index[list.IndexOf(ord)] = 1;
                        flag = false;
                        break;
                    }
                }
            }
            if (flag)
                throw new tempException("找不到对应修改项");
            
            for (int i = 0; i < list.Count; i++)
            {
                if (index[i] == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("输入对应数字选择修改项");
                        Console.WriteLine("1.客户 2.下单时间 3.配送地址 4.总金额 5.货物种类 6.单价 7.数量 0.退出");
                        select = int.Parse(Console.ReadLine());
                        switch (select)
                        {
                            case 1:
                                list[index[i]].customer.Name = Console.ReadLine();
                                break;
                            case 2:
                                list[index[i]].customer.Time = Console.ReadLine();
                                break;
                            case 3:
                                list[index[i]].customer.Address = Console.ReadLine();
                                break;
                            case 4:
                                list[index[i]].TotalAmount = int.Parse(Console.ReadLine());
                                break;
                            case 5:
                                list[index[i]].orderDetails.commodit.Name = Console.ReadLine();
                                break;
                            case 6:
                                list[index[i]].orderDetails.commodit.UnitPrice = double.Parse(Console.ReadLine());
                                break;
                            case 7:
                                list[index[i]].orderDetails.Quantity = int.Parse(Console.ReadLine());
                                break;
                            case 0:
                            default:
                                break;
                        }
                        if (select == 0)
                        {
                            break;
                        }
                    }
                }
                else
                    continue;
            }
        }

        public List<Order> checkOrder()
        {
            List<Order> tempList = new List<Order>();
            int select;
            string tempStr;
            double tempDouble;
            int tempInt;
            Console.WriteLine("选择项：1.客户 2.下单时间 3.配送地址 4.总金额 5.货物种类 6.单价 7.数量 8.ID");
            Console.Write("输入对应数字选择查询项:");
            select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    tempStr = Console.ReadLine();
                    return (from n in list where n.customer.Name == tempStr orderby n.TotalAmount select n).ToList();
                case 2:
                    tempStr = Console.ReadLine();
                    return (from n in list where n.customer.Time == tempStr orderby n.TotalAmount select n).ToList();
                case 3:
                    tempStr = Console.ReadLine();
                    return (from n in list where n.customer.Address == tempStr orderby n.TotalAmount select n).ToList();
                case 4:
                    tempDouble = double.Parse(Console.ReadLine());
                    return (from n in list where n.TotalAmount == tempDouble orderby n.TotalAmount select n).ToList();
                case 5:
                    tempStr = Console.ReadLine();
                    return (from n in list where n.orderDetails.commodit.Name == tempStr orderby n.TotalAmount select n).ToList();
                case 6:
                    tempDouble = double.Parse(Console.ReadLine());
                    return (from n in list where n.orderDetails.commodit.UnitPrice == tempDouble orderby n.TotalAmount select n).ToList();
                case 7:
                    tempInt = int.Parse(Console.ReadLine());
                    return (from n in list where n.orderDetails.Quantity == tempInt orderby n.TotalAmount select n).ToList();
                case 8:
                    tempInt = int.Parse(Console.ReadLine());
                    return (from n in list where n.OrderID == tempInt orderby n.TotalAmount select n).ToList();
                default:
                    Console.WriteLine("Wrong select");
                    return null;
            }

        }

        public void sortOrder(int select)
        {
            switch (select)
            {
                case 1:
                    list.Sort((o1, o2) => o1.OrderID> o2.OrderID?1:0);
                    break;
                case 2:
                    list.Sort((o1, o2) => o1.TotalAmount > o2.TotalAmount?1:(o1.TotalAmount<o2.TotalAmount)?-1:0);
                    break;
                case 3:
                    list.Sort((o1, o2) => o1.orderDetails.commodit.UnitPrice > o2.orderDetails.commodit.UnitPrice ? 1 : (o1.orderDetails.commodit.UnitPrice < o2.orderDetails.commodit.UnitPrice) ? -1 : 0);
                    break;
                case 4:
                    list.Sort((o1, o2) => o1.orderDetails.Quantity > o2.orderDetails.Quantity ? 1 : (o1.orderDetails.Quantity < o2.orderDetails.Quantity) ? -1 : 0);
                    break;
            }
        }

        public void printOrder(List<Order> tempList)
        {
            foreach(Order o in tempList)
            {
                Console.WriteLine(o);
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
            using (FileStream fs = new FileStream(path + "OrderList.xml", FileMode.Create))
            {
                xmlTemp.Serialize(fs, orders);
            }
        }

        public void Import(string path)
        {
            if (!File.Exists(path)||!path.EndsWith(".xml"))
            {
                Console.WriteLine("WrongEnter!");
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
                foreach(Order od in orders)
                {
                    list.Add(od);
                }
                printOrder(list);
            }
            catch(IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();
            os.beginService();
        }
    }
}
