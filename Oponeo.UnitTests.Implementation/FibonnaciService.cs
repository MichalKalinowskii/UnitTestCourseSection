using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oponeo.UnitTests.Implementation
{
    public class FibonnaciService
    {
        public int GetValueOnIndexInFibonnaci(int index)
        {
            if (index < 0) throw new ArgumentOutOfRangeException();
            if (index == 0 || index == 1) return 1;

            
            return GetValueOnIndexInFibonnaci(index - 1) + GetValueOnIndexInFibonnaci(index - 2);

        }
    }
}
