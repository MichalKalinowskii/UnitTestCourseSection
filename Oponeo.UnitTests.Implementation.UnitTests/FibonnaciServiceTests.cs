using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.UnitTests.Implementation.UnitTests
{
    [TestClass]
    public class FibonnaciServiceTests
    {
        [TestMethod]
        public void Should_Return_Correct_Fibonnaci()
        {
            var fizzBuzzService = new FibonnaciService();

            int res = fizzBuzzService.GetValueOnIndexInFibonnaci(5);
            //0,1,1,2,3,5,8
            Assert.AreEqual(8, res);
        }
    }
}
