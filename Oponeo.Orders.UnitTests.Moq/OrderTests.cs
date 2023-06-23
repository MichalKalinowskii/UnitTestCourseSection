using Moq;
using Oponeo.Orders.BusinessLogic;
using Oponeo.Orders.Domain;

namespace Oponeo.Orders.UnitTests.Moq
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Fail_At_ArgumentException()
        {
            var orderValidationMoq = new Mock<IOrderValidator>();
            var discountCodeServiceMoq = new Mock<IDiscountCodeService>();
            var productPriceCalculatoreMoq = new Mock<ProductPriceCalculator>();
            orderValidationMoq.SetupGet(o => o.Validate(It.IsAny<Order>())).Returns(false);


            var orderProcessor = new OrderProcessor(productPriceCalculatoreMoq.Object, orderValidationMoq.Object, discountCodeServiceMoq.Object);

            orderProcessor.ProcessOrder(It.IsAny<Order>());

            Assert.Fail();
        }
    }
}