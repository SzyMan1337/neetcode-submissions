public class Solution {
    public bool CarPooling(int[][] trips, int capacity) {
        Array.Sort(trips, (a, b) => a[1].CompareTo(b[1]));

        var minHeap = new PriorityQueue<int[], int>();
        int curPass = 0;

                foreach (var trip in trips) {
            int numPass = trip[0];
            int start = trip[1];
            int end = trip[2];

            while (minHeap.Count > 0 && minHeap.Peek()[0] <= start) {
                curPass -= minHeap.Dequeue()[1];
            }

            curPass += numPass;
            if (curPass > capacity) {
                return false;
            }

            minHeap.Enqueue(new int[] { end, numPass }, end);
        }

        return true;

    }
}