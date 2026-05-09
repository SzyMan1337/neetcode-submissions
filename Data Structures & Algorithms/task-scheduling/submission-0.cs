public class Solution
{

    private class TaskNode
    {
        public int RemainingCount { get; set; }
        public int AvaibleAt {get; set; }

        public TaskNode(int avaibleAt, int remainingCount)
        {
            AvaibleAt = avaibleAt;
            RemainingCount = remainingCount;
        }
    }
    public int LeastInterval(char[] tasks, int n)
    {
        int[] counter = new int['Z' - 'A' + 1];
        var queue = new Queue<TaskNode>();

        foreach (var c in tasks){
            counter['Z' - c]++;
        }

        var heap = new PriorityQueue<int, int>();

        for (int i = 0; i < counter.Length; i++)
        {
            if(counter[i] >0){
                heap.Enqueue(counter[i], -counter[i]);
            }
        }

        int result = 0;
        while (heap.Count > 0 || queue.Count >0)
        {
            if(heap.Count > 0)
            {
                int el = heap.Dequeue();
                el--;
                if(el >0){
                    queue.Enqueue(new TaskNode(result+1+n, el));
                }
            }
            result++;

            if (queue.Count > 0 && queue.Peek().AvaibleAt <= result)
            {
                var el = queue.Dequeue();
                heap.Enqueue(el.RemainingCount, -el.RemainingCount);
            }
        }

        return result;
    }
}
