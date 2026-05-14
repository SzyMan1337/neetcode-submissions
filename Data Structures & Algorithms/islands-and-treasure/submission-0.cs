public class Solution {
    private int[][] directions = new int[][] { new int[] { 1, 0 }, new int[] { -1, 0 },
                                               new int[] { 0, 1 }, new int[] { 0, -1 } };

    public void islandsAndTreasure(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;

        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (grid[i][j] == 0) {
                    BFS(grid, i, j);
                }
            }
        }
    }

    public void BFS(int[][] grid, int i, int j) {
        var queue = new Queue<(int, int, int)>();
        queue.Enqueue((i, j, 1));

        while (queue.Count > 0) {
            var (r, c, p) = queue.Dequeue();

            foreach (var d in directions) {
                var dr = d[0] + r;
                var dc = d[1] + c;

                if (dr >= 0 && dr < grid.Length && 
                    dc >= 0 && dc < grid[0].Length &&
                    grid[dr][dc] > 0 &&  
                    grid[dr][dc] > p) {
                        grid[dr][dc] = p;
                        queue.Enqueue((dr,dc,p+1));
                }
            }
        }
    }
}
