public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        int[] dp = new int[target + 1];
        dp[0] = 1;

        for (int total = 1; total <= target; total++) {
            foreach (int num in nums) {
                if (total - num >= 0) {
                    dp[total] += dp[total - num];
                }
            }
        }

        return dp[target];
    }
}