using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.UnitTests.Implementation.UnitTests
{
    [TestClass]
    public class PriceCalculatorTest
    {

        [TestMethod]
        [DataRow(10, 80, 1, 7)]
        [DataRow(100, 66, 3, 70)]
        [DataRow(35, 120, 8000, 35 * 0.7)]
        [DataRow(77, 90, 800, 77 * 0.7)]
        public void Should_Return_30_Discount(int price, int age, int daysFromLastVisit, double expectedPrice)
        {
            var calculator = new PriceCalculator();

            double res = calculator.CalculatePrice(price, age, daysFromLastVisit);

            Assert.AreEqual(expectedPrice, res);
        }

        [TestMethod]
        [DataRow(10, 30, 200, 5)]
        [DataRow(100, 50, 201, 50)]
        [DataRow(35, 40, 351, 35 * 0.5)]
        [DataRow(77, 13, 685, 77 * 0.5)]
        public void Should_Return_50_Discount(int price, int age, int daysFromLastVisit, double expectedPrice)
        {
            var calculator = new PriceCalculator();

            double res = calculator.CalculatePrice(price, age, daysFromLastVisit);

            Assert.AreEqual(expectedPrice, res);
        }

        [TestMethod]
        [DataRow(10, 0, 200, 0)]
        [DataRow(100, 1, 201, 0)]
        [DataRow(35, 2, 351, 0)]
        [DataRow(77, 3, 685, 0)]
        public void Should_Return_100_Discount(int price, int age, int daysFromLastVisit, double expectedPrice)
        {
            var calculator = new PriceCalculator();

            double res = calculator.CalculatePrice(price, age, daysFromLastVisit);

            Assert.AreEqual(expectedPrice, res);
        }
    }
}
