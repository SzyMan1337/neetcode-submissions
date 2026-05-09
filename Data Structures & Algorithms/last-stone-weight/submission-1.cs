public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> minHeap = new();

        for(int i =0; i<stones.Length; i++){
            minHeap.Enqueue(stones[i], -stones[i]);
        }

        while(minHeap.Count >1){
            var first = minHeap.Dequeue();
            var second = minHeap.Dequeue();

            if(first == second){
                continue;
            }

            var newStone = first-second;
            minHeap.Enqueue(newStone, -newStone);
        }

        return minHeap.Count >0? minHeap.Dequeue():0;
    }
}
