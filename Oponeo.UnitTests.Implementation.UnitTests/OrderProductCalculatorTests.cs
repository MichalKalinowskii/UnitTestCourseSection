﻿using System;
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

        private List<OrderProduct> _products;

        [TestInitialize]
        public void Products()
        {
            List<OrderProduct> products = new()
            {
                new OrderProduct
                {
                    UnitPrice = 10,
                    Quantity = 1
                },
                new OrderProduct
                {
                    UnitPrice = 12.5,
                    Quantity = 8

                },
                new OrderProduct
                {
                    UnitPrice = 3.5,
                    Quantity = 48
                }
            };

            _products = products;
        }

        [TestMethod]
        public void Should_Return_200Sum_And_One_10Quantity_Discount()
        {

            OrderProductCalculator calc = new(_products);

            double sum = calc.CalculateOrderPrice();

            Assert.AreEqual(235.08, Math.Round(sum,2));
        }

    }
}
