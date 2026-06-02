public class Solution {
    public int Change(int amount, int[] coins) {
        int n = coins.Length;
        int[] dp = new int[amount + 1];
        dp[0] = 1;

        for(int i =n-1; i>=0; i--){
            int[] nextDP = new int[amount + 1];
            for (int a = 1; a <= amount; a++) {
                if (a - coins[i] >= 0) {
                    dp[a] += dp[a - coins[i]];
                }
            }
        }

        return dp[amount];
    }
}