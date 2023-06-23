using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.Orders.BusinessLogic
{
    public interface IDiscountCodeService
    {
        IEnumerable<string> GetAvailableCodes();
        bool UseCode(string code);
    }

    public class DiscountCodesService : IDiscountCodeService
    {
        public IEnumerable<string> GetAvailableCodes()
        {
            return new List<string>
            {
                "1234",
                "1111",
                "2222",
                "3333"
            };
        }

        public bool UseCode(string code)
        {
            if(GetAvailableCodes().Contains(code))
                return true;
            return false;
        }
    }
}
