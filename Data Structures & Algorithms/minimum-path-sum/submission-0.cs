public class Solution {
    public int MinPathSum(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;

        var dp = new int[m];

        for (int i = n - 1; i >= 0; i--) {
            var newDp = new int[m];
            for (int j = m - 1; j >= 0; j--) {
                if(j==m-1 && i==n-1){
                    newDp[j] = grid[i][j];
                    continue;
                }

                int right = j + 1 < m ? newDp[j + 1] : int.MaxValue;
                int bottom = i == n-1 ? int.MaxValue:dp[j];
                newDp[j] = Math.Min(bottom, right) + grid[i][j];
            }
            dp=newDp;
        }

        return dp[0];
    }
}