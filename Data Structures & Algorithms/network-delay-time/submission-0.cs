public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        var nodes = new List<List<(int, int)>>();
        for (int i = 0; i <= n; i++) {
            nodes.Add(new List<(int, int)>());
        }

        foreach (var t in times) {
            nodes[t[0]].Add((t[1], t[2]));
        }

        var visited = new HashSet<int>();
        int visitCount = 0;
        var queue = new PriorityQueue<(int, int), int>();
        queue.Enqueue((k, 0), 0);

        while (queue.Count > 0) {
            var (node, priority) = queue.Dequeue();

            if (visited.Contains(node)) continue;
            visited.Add(node);
            visitCount++;

            if (visitCount == n) return priority;

            foreach (var (vi, ti) in nodes[node]) {
                if (!visited.Contains(vi)) {
                    queue.Enqueue((vi, priority + ti), priority + ti);
                }
            }
        }

        return -1;
    }
}
