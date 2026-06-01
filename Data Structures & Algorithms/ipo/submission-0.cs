public class Solution {
    public int FindMaximizedCapital(int k, int w, int[] profits, int[] capital) {
        var minCapital = new PriorityQueue<int, int>(); // index with capital as priority
        var maxProfit = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a))); // max heap by profit

        for (int i = 0; i < capital.Length; i++) {
            minCapital.Enqueue(i, capital[i]);
        }

        for (int i = 0; i < k; i++) {
            while (minCapital.Count > 0 && capital[minCapital.Peek()] <= w) {
                int idx = minCapital.Dequeue();
                maxProfit.Enqueue(profits[idx], profits[idx]);
            }

            if (maxProfit.Count == 0) {
                break;
            }

            w += maxProfit.Dequeue();
        }

        return w;
    }
}