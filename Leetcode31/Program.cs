using System;

namespace Leetcode31
{
    class Program
    {
        static void Main (string[] args)
        {
            Solution solu = new Solution ();

            int[] nums = new int[]
            {
                2,3,1,3,3
            };

            solu.NextPermutation (nums);

            foreach (var num in nums)
            {
                Console.Write ("{0}, ", num);
            }
        }
    }

    public class Solution
    {
        public void NextPermutation (int[] nums)
        {
            if (nums == null || nums.Length <= 1) return;

            int i = nums.Length - 1;

            for (; i >= 1; i--)
            {
                if (nums[i] > nums[i - 1]) break;
            }

            if (i != 0)
            {
                Offset (i - 1, nums);
            }
            else // inverse total array
            {
                InverseArray (nums, 0, nums.Length - 1);
            }
        }

        private void InverseArray (int[] nums, int start, int end)
        {
            while (start < end)
            {
                nums[start] = nums[start] + nums[end];
                nums[end] = nums[start] - nums[end];
                nums[start] = nums[start] - nums[end];
                start++;
                end--;
            }
        }

        private void Offset (int idx, int[] nums)
        {
            int minIdx = idx + 1;

            for (int t = idx + 1; t < nums.Length; t++)
            {
                if (nums[t] <= nums[minIdx] && nums[t] > nums[idx])
                {
                    minIdx = t;
                }
            }

            nums[minIdx] += nums[idx];
            nums[idx] = nums[minIdx] - nums[idx];
            nums[minIdx] -= nums[idx];

            InverseArray (nums, idx + 1, nums.Length - 1);
        }
    }
}