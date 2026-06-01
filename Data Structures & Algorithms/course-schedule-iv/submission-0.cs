public class Solution {
    public List<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries) {
        Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();
        for (int i = 0; i < numCourses; i++) {
            adj[i] = new List<int>();
        }

        foreach (var pair in prerequisites) {
            int prereq = pair[0], crs = pair[1];
            adj[crs].Add(prereq);
        }

        Dictionary<int, HashSet<int>> prereqMap = new Dictionary<int, HashSet<int>>();

        HashSet<int> Dfs(int crs) {
            if (!prereqMap.ContainsKey(crs)) {
                prereqMap[crs] = new HashSet<int>();
                foreach (var prereq in adj[crs]) {
                    prereqMap[crs].UnionWith(Dfs(prereq));
                }
                prereqMap[crs].Add(crs);
            }
            return prereqMap[crs];
        }

        for (int crs = 0; crs < numCourses; crs++) {
            Dfs(crs);
        }

        List<bool> res = new List<bool>();
        foreach (var q in queries) {
            res.Add(prereqMap.ContainsKey(q[1]) && prereqMap[q[1]].Contains(q[0]));
        }

        return res;
    }
}