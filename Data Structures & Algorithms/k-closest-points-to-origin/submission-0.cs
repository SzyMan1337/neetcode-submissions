public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var heap = new PriorityQueue<int[], double>();
        
        for(int i =0; i<points.Length; i++)
        {
            var dist = Math.Sqrt(points[i][0]*points[i][0] + points[i][1]*points[i][1]);
            heap.Enqueue(points[i], dist);
        }

        var result = new int[k][];

        for(int i=0;i<k;i++)
        {
            result[i] = heap.Dequeue();
        }

        return result;
    }
}
