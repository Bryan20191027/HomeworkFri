using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProgram
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Time { get; set; }
        public Customer()
        {
            this.Time = DateTime.Now.ToString();
        }
        public Customer(string Name, string Address)
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
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("CustomerDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OrderContext>());
        }

        public DbSet<Customer> customers { get; set; }
    }
}
