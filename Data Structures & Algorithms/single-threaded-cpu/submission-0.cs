public class Solution {
    public int[] GetOrder(int[][] tasks) {
        int n = tasks.Length;
        int[] indices = new int[n];
        int i = 0;
        for (; i < n; i++) {
            indices[i] = i;
        }

        Array.Sort(indices, (a, b) =>
            tasks[a][0] != tasks[b][0] ? tasks[a][0].CompareTo(tasks[b][0]) : a.CompareTo(b)
        );

        var minHeap = new PriorityQueue<int, (int procTime, int index)>();

        int[] result = new int[n];
        long time = 0;
        int resIndex =0;
        i=0;

        while(minHeap.Count >0 || i <n){
            while(i<n && tasks[indices[i]][0] <= time){
                int idx = indices[i];
                minHeap.Enqueue(idx, (tasks[idx][1], idx));
                i++;
            }

            if(minHeap.Count == 0){
                time = tasks[indices[i]][0];
            }else{
                int nextIndex = minHeap.Dequeue();
                time += tasks[nextIndex][1];
                result[resIndex++] = nextIndex;
            }
        }

        return result;
    }
}