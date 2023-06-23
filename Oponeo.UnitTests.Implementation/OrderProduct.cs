using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.UnitTests.Implementation
{
    public class OrderProduct
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double TotalPrice => UnitPrice * Quantity;
    }
}
