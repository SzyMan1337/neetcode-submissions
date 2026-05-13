public class Solution {
    public int UniquePaths(int m, int n) {
        var dp = new int[m,n];
        dp[m-1,n-1] = 1;

        for(int r = m-1; r>=0;r--){
            for(int c = n-1; c>=0;c--){
                if(c<n-1){
                    dp[r,c]+=dp[r,c+1];
                }

                if(r<m-1){
                    dp[r,c]+=dp[r+1,c];
                }
            }
        }

        return dp[0,0];
    }
}

