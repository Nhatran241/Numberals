using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numberals
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public int isPrime(int n)
        {
            for(int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % 2 == 0) return 0;

            }
            return 1;
        }
        public long TinhGiaiThua(int n)
        {
            long t=1;
            for(int i = 1; i <= n; i++)
            {
                t *= i;
            }
            return t;
        }
    }
}
