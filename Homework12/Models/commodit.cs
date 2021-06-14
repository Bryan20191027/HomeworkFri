using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderApi.Models
{
public class Commodit
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }

        public Commodit(string Name,double unitPrice)
        {
            this.Name = Name;
            this.UnitPrice = unitPrice;
        }
    }
}