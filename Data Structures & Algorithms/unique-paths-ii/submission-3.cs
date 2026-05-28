public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int n = obstacleGrid.Length;
        int m = obstacleGrid[0].Length;

        if(obstacleGrid[n-1][m-1] == 1){
            return 0;
        }

        var dp = new int[m];

        dp[m-1]=1;
        for(int i =m-2;i>=0;i--){
            if(obstacleGrid[n-1][i] == 1){
                dp[i]=0;
            }else{
                dp[i]=dp[i+1];
            }
        }

        for(int i = n-2;i>=0;i--){
            var newDp = new int[m];
            for(int j=m-1;j>=0;j--){
                if(obstacleGrid[i][j]==1){
                    newDp[j]=0;
                }else{
                    newDp[j]=dp[j]+ ((j+1)<m?newDp[j+1]:0);
                }
            }

            dp=newDp;
        }

        return dp[0];
    }
}