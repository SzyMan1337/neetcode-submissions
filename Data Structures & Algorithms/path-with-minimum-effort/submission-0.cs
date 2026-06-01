public class Solution {
    public int MinimumEffortPath(int[][] heights) {
        var heap = new PriorityQueue<(int row, int col, int heightDiff), int>();
        heap.Enqueue((0, 0, 0), 0);

        var visited = new HashSet<(int, int)>();
        int maxPath = 0;

        int rows = heights.Length;
        int cols = heights[0].Length;

        int[][] dirs = new int[][] {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 }
        };

        while (heap.Count > 0) {
            var (row, col, heightDiff) = heap.Dequeue();

            if (visited.Contains((row, col))) {
                continue;
            }

            visited.Add((row, col));
            maxPath = Math.Max(maxPath, heightDiff);

            if (row == rows - 1 && col == cols - 1) {
                return maxPath;
            }

            foreach (var dir in dirs) {
                int newRow = row + dir[0];
                int newCol = col + dir[1];

                if (newRow < 0 || newRow >= rows ||
                    newCol < 0 || newCol >= cols ||
                    visited.Contains((newRow, newCol))) {
                    continue;
                }

                int newDiff = Math.Abs(heights[row][col] - heights[newRow][newCol]);

                heap.Enqueue((newRow, newCol, newDiff), newDiff);
            }
        }

        return maxPath;
    }
}