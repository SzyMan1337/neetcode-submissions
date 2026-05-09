public class KthLargest {
    
    private PriorityQueue<int, int> Heap;
    private int K;

    public KthLargest(int k, int[] nums) {
        Heap = new PriorityQueue<int, int>();
        K=k;

        foreach(var num in nums){
            Heap.Enqueue(num, num);
            if(Heap.Count > k)
            {
                Heap.Dequeue();
            }
        }
    }
    
    public int Add(int val) {
        Heap.Enqueue(val, val);
        if(Heap.Count > K)
        {
            Heap.Dequeue();
        }
        return Heap.Peek();
    }
}
