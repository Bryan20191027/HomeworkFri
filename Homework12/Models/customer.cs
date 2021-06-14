using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models
{
public class Customer
    {
        [Key]
        public string ID{get;set;}
        public string Name { get; set; }
        public string Address { get; set; }
        public Customer()
        {
            ID = Guid.NewGuid().ToString();
        }
        public Customer(string Name,string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            return customer != null &&
                   ID == customer.ID &&
                   Name == customer.Name&&
                   Address==customer.Address;
        }

        public override int GetHashCode()
        {
            var hashCode = 1479869798;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            return hashCode;
        }
    }
}