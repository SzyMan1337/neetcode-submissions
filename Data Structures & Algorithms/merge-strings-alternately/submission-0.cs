public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int n = word1.Length, m = word2.Length;
        StringBuilder res = new StringBuilder();

        for (int i = 0; i < Math.Max(n, m); i++) {
            if (i < n) {
                res.Append(word1[i]);
            }
            if (i < m) {
                res.Append(word2[i]);
            }
        }

        return res.ToString();
    }
}