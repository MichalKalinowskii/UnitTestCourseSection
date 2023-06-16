using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.UnitTests.Implementation
{
    public class PriceCalculator
    {
        public PriceCalculator()
        {

        }

        public double CalculatePrice(int price, int age, int daysFromLastVisit) 
        {
            if (age > 65) return price * 0.7;
            if (age < 4 && age >= 0) return 0;
            if (daysFromLastVisit >= 200) return price * 0.5;
            return price;
        }

    }
}
