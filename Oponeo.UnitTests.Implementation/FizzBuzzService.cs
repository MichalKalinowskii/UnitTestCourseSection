using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.UnitTests.Implementation
{
    public class FizzBuzzService
    {
        public string FizzBuzzGenerator(int n)
        {
            bool canDivideBy3 = n % 3 == 0;
            bool canDivideBy5 = n % 5 == 0;

            if (canDivideBy3 && canDivideBy5) return "FizzBuzz";
            if (canDivideBy3) return "Fizz";
            if (canDivideBy5) return "Buzz";

            return n.ToString();
        }
    }
}
