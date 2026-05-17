public class Solution {
    public int CountComponents(int n, int[][] edges) {
        var visited = new HashSet<int>();
        var nodes = new List<List<int>>();
        int counter = 0;

        for(int i =0;i<n;i++)
        {
            nodes.Add(new List<int>());
        }

        foreach(var edge in edges)
        {
            int n1 = edge[0];
            int n2 = edge[1];

            nodes[n1].Add(n2);
            nodes[n2].Add(n1);
        }

        for(int j =0;j<n;j++)
        {
            if(!visited.Contains(j))
            {
                DFS(visited, nodes, j);
                counter++;
            }
        }
        return counter;
    }

    public void DFS(HashSet<int> visited, List<List<int>> nodes, int node)
    {
        visited.Add(node);

        foreach(var adj in nodes[node]){
            if(!visited.Contains(adj)){
                DFS(visited, nodes, adj);
            }
        }
    }
}
