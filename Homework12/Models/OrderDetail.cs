using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApi.Models
{ public class OrderDetail
    {
        [Key]
        public string Id { get; set; }
        public Commodit commodit{ get; set; }       
        public int Quantity { get; set; }
        

        public OrderDetail(Commodit com,int Quantity)
        {
            this.commodit=com;
            this.Quantity = Quantity;
        }

        public override bool Equals(object obj)
        {
            var item = obj as OrderDetail;
            return item != null &&
                   Quantity == item.Quantity;
        }

        public override int GetHashCode()
        {
            var hashCode = -2127770830;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(commodit.Name);
            hashCode = hashCode * -1521134295 + Quantity.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return commodit.ToString() + " 数量：" + Quantity;
        }
    }
}