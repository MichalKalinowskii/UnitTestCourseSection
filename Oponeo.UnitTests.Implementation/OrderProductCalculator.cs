using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.UnitTests.Implementation
{
    public class OrderProductCalculator
    {

        private List<OrderProduct> _product;

        public OrderProductCalculator(List<OrderProduct> products)
        {
            _product = products;
        }

        public double CalculateOrderPrice()
        {
            double sum = _product.Sum(p => p.Quantity * p.UnitPrice);

            foreach(var product in _product)
            {
                if (sum > 200)
                    product.UnitPrice *= 0.9;

                if (sum > 400)
                    product.UnitPrice *= 0.8;

                if (product.Quantity > 10)
                    product.UnitPrice *= 0.9;
            }

            return _product.Sum(p => p.Quantity * p.UnitPrice);
        }
    }
}
