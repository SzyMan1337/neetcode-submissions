public class Solution {
    public int LengthOfLIS(int[] nums) {
        if (nums.Length < 1) {
            return 0;
        }

        int n = nums.Length;
        var dp = new int[n];
        Array.Fill(dp,1);

        for (int i = n-2; i >= 0; i--) {
            for(int j =i+1;j<n;j++){
                if(nums[i] < nums[j]){
                    dp[i] = Math.Max(dp[j]+1,dp[i]);
                }
            }
        }

        return dp.Max();
    }
}
