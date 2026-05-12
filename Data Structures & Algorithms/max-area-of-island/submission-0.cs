public class Solution
{
    private static readonly int[][] directions = new int[][] {
        new int[] {1, 0}, new int[] {-1, 0},
        new int[] {0, 1}, new int[] {0, -1}
    };

    public int MaxAreaOfIsland(int[][] grid)
    {
        int maxArea = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (grid[i][j] == 1)
                {
                    maxArea = Math.Max(maxArea, BFS(grid, j, i));
                }
            }
        }

        return maxArea;
    }

    public int BFS(int[][] grid, int c, int r)
    {
        var queue = new Queue<(int, int)>();
        queue.Enqueue((r, c));
        grid[r][c] = 0;
        int res = 1;

        while (queue.Count > 0)
        {
            var (row,col) = queue.Dequeue();

            foreach (var dir in directions) {
                int nr = row + dir[0], nc = col + dir[1];
                if (nr >= 0 && nc >= 0 && nr < grid.Length &&
                    nc < grid[0].Length && grid[nr][nc] == 1) {
                    queue.Enqueue((nr,nc));
                    grid[nr][nc] = 0;
                    res++;
                }
            }
        }

        return res;
    }
}
