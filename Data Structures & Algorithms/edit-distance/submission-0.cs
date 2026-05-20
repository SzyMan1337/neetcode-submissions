public class Solution {
    public int MinDistance(string word1, string word2) {
        int n = word1.Length;
        int m = word2.Length;

        int[,] dp = new int[n + 1, m + 1];

        for (int i = 0; i <= n; i++) {
            dp[i,m] = n - i;
        }
        for (int j = 0; j <= m; j++) {
            dp[n,j] = m - j;
        }

        for (int i = n - 1; i >= 0; i--) {
            for (int j = m - 1; j >= 0; j--) {
                if (word1[i] == word2[j]) {
                    dp[i,j]=dp[i+1,j+1];
                } else {
                    dp[i, j] = 1+Math.Min(dp[i + 1, j + 1], Math.Min(dp[i + 1, j], dp[i, j + 1]));
                }
            }
        }

        return dp[0, 0];
    }
}
