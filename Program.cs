using System;

namespace MaxConsecutiveOnes
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            // Maintain a counter
            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] == 1) {
                    count++;
                }
                else
                {
                    // Get the current maximum of contiguous 1's
                    maxCount = Math.Max(maxCount, count);
                    // Reset the count
                    count = 0;
                }
            }
            return Math.Max(maxCount, count);
        }
    }
}
