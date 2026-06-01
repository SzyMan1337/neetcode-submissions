public class Solution {
    int[][] directions = new int[][] {
        new int[] {-1, 0}, new int[] {1, 0},
        new int[] {0, -1}, new int[] {0, 1}
    };
    int[,] dp;

    public int LongestIncreasingPath(int[][] matrix) {
        int maxPath = 0;
        int n = matrix.Length;
        int m = matrix[0].Length;

        dp = new int[n,m];

        for(int i =0;i<n;i++){
            for(int j =0;j<m;j++){
                maxPath = Math.Max(maxPath, DFS(i,j,matrix));
            }
        }

        return maxPath;
    }

    private int DFS(int row, int col, int[][] matrix){
        if(dp[row,col] != 0){
            return dp[row,col];
        }

        int maxFromDirections = 0;
        foreach(var d in directions){
            int newRow = row+d[0];
            int newCol = col+d[1];

            if(newRow >=0 && newCol >= 0 && newRow < matrix.Length && newCol < matrix[0].Length && 
                matrix[newRow][newCol] > matrix[row][col]){
                    maxFromDirections = Math.Max(maxFromDirections, DFS(newRow, newCol,matrix));
                }
        }

        dp[row,col] = 1+maxFromDirections;

        return dp[row,col];
    }
}