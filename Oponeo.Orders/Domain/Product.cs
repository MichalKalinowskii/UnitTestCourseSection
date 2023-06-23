using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.Orders.Domain
{
    public class Product
    {
        public string Name { get; set; }
        public double TotalPrice => UnitPrice * Quantity;
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
    }
}
