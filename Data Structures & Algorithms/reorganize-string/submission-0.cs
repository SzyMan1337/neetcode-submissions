public class Solution {
    public string ReorganizeString(string s) {
        Dictionary<char, int> count = new();
        foreach (char c in s) {
            if (!count.ContainsKey(c))
                count[c] = 0;
            count[c]++;
        }

        PriorityQueue<int[], int> maxHeap = new();
        foreach (var kvp in count) {
            maxHeap.Enqueue(new int[] { kvp.Value, kvp.Key }, -kvp.Value);
        }

        string res = "";
        int[] prev = null;

        while (maxHeap.Count > 0 || prev != null) {
            if (prev != null && maxHeap.Count == 0)
                return "";

            int[] curr = maxHeap.Dequeue();
            res += (char)curr[1];
            curr[0]--;

            if (prev != null) {
                maxHeap.Enqueue(prev, -prev[0]);
                prev = null;
            }

            if (curr[0] > 0) {
                prev = curr;
            }
        }

        return res;
    }
}