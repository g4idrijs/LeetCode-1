using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class HappyNumberSolution
    {
        public bool isHappy(int n)
        {
            List<int> numbers = new List<int>();
            while (n != 1)
            {
                int m = n;
                n = 0;
                int mod;
                while (m != 0)
                {
                    mod = m % 10;
                    n += mod * mod;
                    m = m / 10;
                }

                if (numbers.Contains(n))
                    return false;

                numbers.Add(n);

            }

            return true;
        }


    }
}
