using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.Orders.Domain
{
    public class Order
    {
        public Guid Guid { get; set; }
        public DateTime OrderDateTime { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<Product> OrderLines { get; set; }
        public string DiscountCode { get; set; }
    }
}
