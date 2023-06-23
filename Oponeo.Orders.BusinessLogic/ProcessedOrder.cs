using Oponeo.Orders.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.Orders.BusinessLogic
{
    public class ProcessedOrder
    {
        public Order Order { get; set; }
        public double NetTotal { get; set; }
    }
}
