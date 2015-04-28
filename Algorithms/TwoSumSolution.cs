
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    ///  类名称：TwoSumSolution
    /// 
    /// </summary>
    /// * 创建人：xierenhong
    /// * 创建时间：2015/4/25 13:33:57
    /// * 修改人：
    /// * 修改时间：
    /// * 修改备注：
    /// * ==============================================================================*/
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> evens = new Dictionary<int, int>();
            Dictionary<int, int> odds = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evens.Add(nums[i], i + 1);
                }
                else
                {
                    odds.Add(nums[i], i + 1);
                }
            }

            if (target % 2 == 0)
            {
                foreach (int even in evens.Keys)
                {
                    foreach (int even2 in evens.Keys)
                    {
                        if (even + even2 == target)
                        {
                            if (evens[even] > evens[even2])
                            {
                                return new[] { evens[even2], evens[even] };
                            }
                            else
                            {
                                return new[] { evens[even], evens[even2] };
                            }
                        }
                    }
                }

                foreach (int even in odds.Keys)
                {
                    foreach (int even2 in odds.Keys)
                    {
                        if (even + even2 == target)
                            if (evens[even] > evens[even2])
                            {
                                return new[] { evens[even2], evens[even] };
                            }
                            else
                            {
                                return new[] { evens[even], evens[even2] };
                            }
                    }
                }
            }
            else
            {
                foreach (int even in evens.Keys)
                {
                    foreach (int even2 in odds.Keys)
                    {
                        if (even + even2 == target)
                        {
                            if (evens[even] > evens[even2])
                            {
                                return new[] { evens[even2], evens[even] };
                            }
                            else
                            {
                                return new[] { evens[even], evens[even2] };
                            }
                        }
                        
                    }
                }
            }

            return null;
        }

        public static int binary(int[] array, int value)
        {
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int middle = (low + high) / 2;
                if (value == array[middle])
                {
                    return middle;
                }
                if (value > array[middle])
                {
                    low = middle + 1;
                }
                if (value < array[middle])
                {
                    high = middle - 1;
                }
            }
            return -1;
        }
    }
}
