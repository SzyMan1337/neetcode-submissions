public class Solution {
    private int[][] directions = new int[][] {
        new int[] { 1, 0 }, new int[] { -1, 0 },
        new int[] { 0, 1 }, new int[] { 0, -1 }
    };

    public int OrangesRotting(int[][] grid) {
        var queue = new Queue<(int,int,int)>();
        int ROWS = grid.Length;
        int COLS = grid[0].Length;
        int fresh=0;

        for(int i=0;i<ROWS;i++){
            for(int j =0; j<COLS; j++){
                if(grid[i][j] == 2){
                    queue.Enqueue((i,j,0));
                }
                if (grid[i][j] == 1) {
                    fresh++;
                }
            }
        }

        int count = 0;
        while(queue.Count>0){
            var (r,c,t) = queue.Dequeue();
            count = t;
            
            foreach(var d in directions){
                int dr = r+d[0];
                int dc = c + d[1];

                if(dr<0 || dr >= ROWS || dc <0 || dc>=COLS || grid[dr][dc] != 1){
                    continue;
                }

                grid[dr][dc] = 2;
                fresh--;
                queue.Enqueue((dr,dc,t+1));
            }
        }

        return fresh == 0 ? count : -1;
    }
}
