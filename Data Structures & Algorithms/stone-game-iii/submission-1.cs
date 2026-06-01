public class Solution {
    public string StoneGameIII(int[] stoneValue) {
        int n = stoneValue.Length;
        Dictionary<int, int> dp = new Dictionary<int, int>();

        int Dfs(int i) {
            if (i >= n) return 0;
            if (dp.ContainsKey(i)) return dp[i];

            int res = int.MinValue, total = 0;
            for (int j = i; j < Math.Min(i + 3, n); j++) {
                total += stoneValue[j];
                res = Math.Max(res, total - Dfs(j + 1));
            }

            dp[i] = res;
            return res;
        }

        int result = Dfs(0);
        if (result == 0) return "Tie";
        return result > 0 ? "Alice" : "Bob";
    }
}