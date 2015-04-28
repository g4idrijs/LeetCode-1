
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    ///  类名称：CountPrimesSolution
    /// 
    /// </summary>
    /// * 创建人：xierenhong
    /// * 创建时间：2015/4/27 12:55:26
    /// * 修改人：
    /// * 修改时间：
    /// * 修改备注：
    /// * ==============================================================================*/
    public class CountPrimesSolution
    {
        //Time Limit Exceeded
        public int CountPrimes(int n)
        {
            int count;

            if (n <= 2) return 0;
            if (n == 3) return 1;

            count = 1;
            bool isPrime;
            double nSqrt = Math.Sqrt(n);
            for (int i = 3; i < n; i = i + 2)
            {
                isPrime = true;
                for (int j = 3; j < nSqrt; j++)
                {
                    if (i == 3)
                    {
                        break;
                    }
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    count++;
            }

            return count;
        }

        //Memory Limit Exceeded
        public int CountPrimes2(int n)
        {
            if (n <= 2)
                return 0;

            int[] primes = new int[n];
            primes[0] = 1;
            primes[1] = 1;

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                for (int j = i; j < primes.Length; j = j + i)
                {
                    if (j != i)
                    {
                        primes[j] = 1;
                    }
                }
            }

            int count = 0;
            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i] == 0)
                    count++;
            }

            return count;
        }

        public int CountPrimes3(int n)
        {
            if (n <= 2)
                return 0;

            int count = 0;

            List<int> primes = new List<int>();
            primes.Add(2);
            foreach (int prime in primes)
            {

            }

            return count;
        }
    }
}
