using System;
using System.Collections;

namespace Leetcode11
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            var heights = new int[] 
            {
                1, 2, 3, 4
            };

            Console.WriteLine(solution.MaxArea(heights));
        }
    }

    public class Solution {
        public int MaxArea(int[] height) 
        {
            int low = 0;
            int high = height.Length - 1;
            int maxArea = 0;

            while(low < high)
            {
                int curArea = high - low;

                if(height[low] < height[high])
                {
                    curArea *= height[low];
                    low++;
                }
                else
                {
                    curArea *= height[high];
                    high--;
                }

                if(curArea > maxArea)   maxArea = curArea;
            }    

            return maxArea;
        }
    }
}
