public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        var nodeEdges = new Dictionary<int, List<int>>();
        foreach (var edge in edges) {
            if(edge[0] == edge[1]){
                return false;
            }

            if (!nodeEdges.ContainsKey(edge[0])) {
                nodeEdges[edge[0]] = new();
            }
            if (!nodeEdges.ContainsKey(edge[1])) {
                nodeEdges[edge[1]] = new();
            }

            nodeEdges[edge[1]].Add(edge[0]);
            nodeEdges[edge[0]].Add(edge[1]);
        }

        if (n < 2) {
            return true;
        }
        if(!nodeEdges.ContainsKey(0) || nodeEdges[0].Count == 0){
            return false;
        }
        var stack = new Stack<(int,int)>();
        var visited = new HashSet<int>();
        stack.Push((0,-1));
        visited.Add(0);

        while (stack.Count > 0) {
            var (node, prevNode) = stack.Pop();
   
            foreach(var ad in nodeEdges[node]){
                if(ad == prevNode){
                    continue;
                }

                if(visited.Contains(ad)){
                    return false;
                }
                visited.Add(ad);
                stack.Push((ad,node));  
            }
        }

        return visited.Count == n ? true : false;
    }
}
