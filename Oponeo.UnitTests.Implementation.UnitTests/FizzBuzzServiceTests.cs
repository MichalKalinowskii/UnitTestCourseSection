using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oponeo.UnitTests.Implementation.UnitTests
{
    [TestClass]
    public class FizzBuzzServiceTests
    {
        [TestMethod]
        [DataRow(9, "Fizz")]
        [DataRow(10, "Buzz")]
        [DataRow(120, "FizzBuzz")]
        [DataRow(2, "2")]
        public void Should_Return_Correct_Result(int n, string reuslt)
        {
            var fizzBuzzService = new FizzBuzzService();

            string res = fizzBuzzService.FizzBuzzGenerator(n);

            Assert.AreEqual(res, reuslt);
        }

        [TestMethod]
        [DataRow(10, "Fizz")]
        [DataRow(9, "Buzz")]
        [DataRow(2, "FizzBuzz")]
        public void Should_Return_Incorrect_Result(int n, string reuslt)
        {
            var fizzBuzzService = new FizzBuzzService();

            string res = fizzBuzzService.FizzBuzzGenerator(n);

            Assert.AreNotEqual(res, reuslt);
        }


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
