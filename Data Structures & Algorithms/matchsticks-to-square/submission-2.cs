public class Solution {
    public bool Makesquare(int[] matchsticks) {
        int totalLength = 0;
        foreach (int stick in matchsticks) {
            totalLength += stick;
        }

        if (totalLength % 4 != 0) {
            return false;
        }

        int length = totalLength / 4;
        int[] sides = new int[4];
        Array.Sort(matchsticks, (a, b) => b.CompareTo(a)); // Sort in descending order

        bool Dfs(int i) {
            if (i == matchsticks.Length) {
                return true;
            }

            for (int side = 0; side < 4; side++) {
                if (sides[side] + matchsticks[i] <= length) {
                    sides[side] += matchsticks[i];
                    if (Dfs(i + 1)) return true;
                    sides[side] -= matchsticks[i];
                }

                if (sides[side] == 0) break;
            }

            return false;
        }

        return Dfs(0);
    }
}