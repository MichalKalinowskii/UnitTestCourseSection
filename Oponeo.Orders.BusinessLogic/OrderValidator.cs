using Oponeo.Orders.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.Orders.BusinessLogic
{
    public interface IOrderValidator
    {
        bool Validate(Order order);
    }

    public class OrderValidator : IOrderValidator
    {
        public bool Validate(Order order)
        {
            if (order.OrderLines == null || !order.OrderLines.Any())
            {
                return false;
            }
            else if (order.Customer == null)
            {
                return false;
            }

            return true;
        }
    }
}
