public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int n = text1.Length;
        int m = text2.Length;

        var dp = new int[n+1,m+1];

        for(int i =m-1; i>=0;i--){
            char c = text2[i];

            for(int j = n-1; j>=0;j--){
                if(c == text1[j]){
                    dp[j,i] = Math.Max(dp[j,i], dp[j+1,i+1] +1);
                }
                else
                {
                    dp[j,i] = Math.Max(dp[j,i+1], dp[j+1,i]);
                }
            }
        }

        return dp[0,0];
    }
}
