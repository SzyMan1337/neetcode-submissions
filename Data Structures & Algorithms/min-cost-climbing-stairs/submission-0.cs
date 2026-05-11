public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        var minCosts = new int[n + 2];
        minCosts[n + 1] = 0;
        minCosts[n] = 0;

        for (int i = n - 1; i >= 0; i--)
        {
            minCosts[i] = cost[i] + Math.Min(minCosts[i + 1], minCosts[i + 2]);
        }

        return Math.Min(minCosts[0], minCosts[1]);
    }
}
