public class Solution {
    public int MinCostConnectPoints(int[][] points) {
        var nodes = new List<List<(int, int)>>();
        int n = points.Length;

        for (int i = 0; i < n; i++) {
            nodes.Add(new List<(int, int)>());
        }

        for (int i = 0; i < n - 1; i++) {
            for (int j = i + 1; j < n; j++) {
                var dist =
                    Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);

                nodes[i].Add((j, dist));
                nodes[j].Add((i, dist));
            }
        }

        int cost = 0;
        var minHeap = new PriorityQueue<(int, int),int>();
        var visited = new HashSet<int>();

        minHeap.Enqueue((0,0),0);

        while(minHeap.Count >0){
            var (node, distance) = minHeap.Dequeue();
            if(visited.Contains(node)){
                continue;
            }
            visited.Add(node);
            cost += distance;


            if(visited.Count == n){
                break;
            }
            
            foreach(var (node2, distance2) in nodes[node]) {
                if(visited.Contains(node2)){
                    continue;
                }

                minHeap.Enqueue((node2, distance2), distance2);
            }
        }

        return cost;
    }
}
