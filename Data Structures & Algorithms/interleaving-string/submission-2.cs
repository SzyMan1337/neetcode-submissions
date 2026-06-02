public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        if (s1.Length + s2.Length != s3.Length) {
            return false;
        }

        bool[,] dp = new bool[s1.Length + 1, s2.Length + 1];
        dp[s1.Length, s2.Length] = true;

        for (int i = s1.Length - 1; i >= 0; i--) {
            dp[i, s2.Length] = dp[i + 1, s2.Length] && s1[i] == s3[s2.Length + i];
        }
        for (int j = s2.Length - 1; j >= 0; j--) {
            dp[s1.Length, j] = dp[s1.Length, j + 1] && s2[j] == s3[s1.Length + j];
        }

        for (int i = s1.Length - 1; i >= 0; i--) {
            for (int j = s2.Length - 1; j >= 0; j--) {
                if (s1[i] == s3[i + j] && dp[i + 1, j]) {
                    dp[i, j] = true;
                } else if (s2[j] == s3[i + j] && dp[i, j + 1]) {
                    dp[i, j] = true;
                }
            }
        }

        return dp[0, 0];
    }
}
