public class Solution {
    public int SwimInWater(int[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length;
        int[][] directions = { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 },
                               new int[] { -1, 0 } };

        int maxOnRoad = grid[0][0];
        var heap = new PriorityQueue<(int, int), int>();
        heap.Enqueue((0, 0), maxOnRoad);
        grid[0][0] = -grid[0][0];

        while (heap.Count > 0) {
            var (row, col) = heap.Dequeue();
            maxOnRoad = Math.Max(maxOnRoad, -grid[row][col]);

            if (row == n - 1 && col == m - 1) {
                return maxOnRoad;
            }

            foreach (var d in directions) {
                int newRow = row + d[0];
                int newCol = col + d[1];

                if (newRow >= 0 && newCol >= 0 && newRow < n && newCol < m &&
                    grid[newRow][newCol] >= 0) {
                    heap.Enqueue((newRow, newCol), grid[newRow][newCol]);
                    grid[newRow][newCol] = -grid[newRow][newCol];
                }
            }
        }

        return maxOnRoad;
    }
}
