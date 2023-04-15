using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Algorithms
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - i -1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        var temp = nums[j]; 
                        nums[j] = nums[j + 1]; 
                        nums[j + 1] = temp;
                    }
                }
            }
            return nums;
        }
    }
}
