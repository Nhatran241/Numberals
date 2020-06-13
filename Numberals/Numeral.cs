using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberals
{
    class Numeral
    {
        public int isPrime(int n)
        {
            for(int i = 2; i < sqrt(n); i++)
            {
                if (n % 2 == 0) return 0;
            }
            return 1;
        }
    }
}
