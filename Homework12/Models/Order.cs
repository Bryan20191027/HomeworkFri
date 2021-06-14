using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OrderApi.Models
{ 
    /**
     **/
    public class Order : IComparable<Order>
    {

        [Key]
        public string Id { get; set; }

        public String CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public DateTime Time { get; set; }

        public List<OrderDetail> orderDetails { get; set; }


        public Order()
        {
            Id = Guid.NewGuid().ToString();
            orderDetails = new List<OrderDetail>();
            Time = DateTime.Now;
        }

        public Order(string id){
            Id = id;
            orderDetails = new List<OrderDetail>();
            Time = DateTime.Now;
        }

        public Order(Customer customer, List<OrderDetail> details) : this()
        {
            this.Customer = customer;
            this.Time = DateTime.Now;
            if (details != null) orderDetails=details;
        }

        public void AddDetails(OrderDetail Details)
        {
            if (orderDetails.Contains(Details))
                throw new ApplicationException("订单项已存在");
            orderDetails.Add(Details);
        }

        public void RemoveItem(OrderDetail Details)
        {
            orderDetails.Remove(Details);
        }

        public override string ToString()
        {
            return "id:"+Id+"time:"+Time;
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null &&
                   Id == order.Id;
        }

        public override int GetHashCode()
        {
            var hashCode = -531220479;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Customer.Name);
            hashCode = hashCode * -1521134295 + Time.GetHashCode();
            return hashCode;
        }

        public int CompareTo(Order other)
        {
            if (other == null) return 1;
            return this.Id.CompareTo(other.Id);
        }
    }
}