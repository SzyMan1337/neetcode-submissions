public class Solution {
    public List<List<int>> PermuteUnique(int[] nums) {
        var res = new List<List<int>>();
        var perm = new List<int>();
        var count = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (!count.ContainsKey(num)) {
                count[num] = 0;
            }
            count[num]++;
        }


        void Dfs() {
            if (perm.Count == nums.Length) {
                res.Add(new List<int>(perm));
                return;
            }

            foreach (var kvp in count) {
                int num = kvp.Key;
                if (count[num] > 0) {
                    perm.Add(num);
                    count[num]--;
                    Dfs();
                    count[num]++;
                    perm.RemoveAt(perm.Count - 1);
                }
            }
        }

        Dfs();
        return res;
    }
}