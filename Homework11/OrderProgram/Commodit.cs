using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderProgram
{
    public class Commodit
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }

        public override string ToString()
        {
            return "货物种类：" + Name + " 货物单价：" + UnitPrice;
        }
        public Commodit(string Name, double unitPrice)
        {
            this.Name = Name;
            this.UnitPrice = unitPrice;
        }

        public Commodit()
        {

        }
    }
}
