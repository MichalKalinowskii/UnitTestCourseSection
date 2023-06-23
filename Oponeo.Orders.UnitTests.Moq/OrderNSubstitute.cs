using NSubstitute;
using NSubstitute.ExceptionExtensions;
using Oponeo.Orders.BusinessLogic;
using Oponeo.Orders.Domain;
using Shouldly;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.Orders.UnitTests.Moq
{
    [TestClass]
    public class OrderNSubstitute
    {
        [TestMethod]
        public void Should_Fail_At_ArgumentException()
        {
            var productPriceCalculatoreSub = Substitute.For<ProductPriceCalculator>();
            var orderValidationSub = Substitute.For<IOrderValidator>();
            var discountCodeServiceSub = Substitute.For<IDiscountCodeService>();
            orderValidationSub.Validate(new Order()).Returns(false);


            var orderProcessor = new OrderProcessor(productPriceCalculatoreSub, orderValidationSub, discountCodeServiceSub);

            Should.Throw<ArgumentException>(() => orderProcessor.ProcessOrder(new Order()));

            //Assert.Fail();
        }

    }
}
