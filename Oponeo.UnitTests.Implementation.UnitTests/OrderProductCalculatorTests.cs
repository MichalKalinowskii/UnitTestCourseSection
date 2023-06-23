using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.UnitTests.Implementation.UnitTests
{
    [TestClass]
    public class OrderProductCalculatorTests
    {

        [TestMethod]
        public void Should_Return_200Sum_And_One_10Quantity_Discount()
        {
            List<OrderProduct> products = new();
            products.Add(new OrderProduct
            {
                UnitPrice = 10,
                Quantity = 1
            });
            products.Add(new OrderProduct
            {
                UnitPrice = 12.5,
                Quantity = 8

            });
            products.Add(new OrderProduct
            {
                UnitPrice = 3.5,
                Quantity = 48
            });

            OrderProductCalculator calc = new(products);

            double sum = calc.CalculateOrderPrice();


            Assert.AreEqual(235.08, Math.Round(sum,2));
        }

    }
}
