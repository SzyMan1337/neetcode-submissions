public class Solution {
    public int CombinationSum4(int[] nums, int target) {
        Dictionary<int, int> dp = new Dictionary<int, int>();
        dp[0] = 1;

        for (int total = 1; total <= target; total++) {
            dp[total] = 0;
            foreach (int num in nums) {
                if (dp.ContainsKey(total - num)) {
                    dp[total] += dp[total - num];
                }
            }
        }

        return dp[target];
    }
}