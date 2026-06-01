public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int globMax = nums[0], globMin = nums[0];
        int curMax = 0, curMin = 0, total = 0;

        foreach (int num in nums) {
            curMax = Math.Max(curMax + num, num);
            globMax = Math.Max(globMax, curMax);

            curMin = Math.Min(curMin + num, num);
            globMin = Math.Min(globMin, curMin);

            total += num;
        }

        return globMax > 0 ? Math.Max(globMax, total - globMin) : globMax;
    }
}