public class Solution
{
    private static int[][] directions = new int[][] {new int[] { -1, 0 }, new int[] { 1, 0 },
                                         new int[] { 0, -1 }, new int[] { 0, 1 } };

    public void Solve(char[][] board)
    {
        int ROWS = board.Length;
        int COLS = board[0].Length;
        var hashSet = new HashSet<(int, int)>();

        for (int i = 0; i < ROWS; i++)
        {
            for (int j = 0; j < COLS; j++)
            {
                if (board[i][j] == 'O' && !hashSet.Contains((i, j)))
                {
                    BFS(board, i, j, hashSet);
                }
            }
        }
    }

    public void BFS(char[][] board, int i, int j, HashSet<(int, int)> hashSet)
    {
        var visited = new HashSet<(int, int)>();
        var queue = new Queue<(int, int)>();
        queue.Enqueue((i, j));
        visited.Add((i, j));

        bool water = false;
        while (queue.Count > 0)
        {
            var (r, c) = queue.Dequeue();

            foreach (var d in directions)
            {
                var dr = r + d[0];
                var dc = c + d[1];

                if (!visited.Contains((dr, dc)) && dr >= 0 && dc >= 0 && dr < board.Length &&
                    dc < board[0].Length && board[dr][dc] == 'O')
                {
                    queue.Enqueue((dr, dc));
                    visited.Add((dr, dc));
                }

                if (dr < 0 || dc < 0 || dr >= board.Length || dc >= board[0].Length)
                {
                    water = true;
                }
            }
        }

        if (!water)
        {
            foreach (var (row, col) in visited)
            {
                board[row][col] = 'X';
            }
        }
        else
        {
            hashSet.UnionWith(visited);
        }
    }
}
