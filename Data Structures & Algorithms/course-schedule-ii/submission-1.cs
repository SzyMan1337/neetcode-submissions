public class Solution {
    private Dictionary<int, List<int>> preMap = new();
    private HashSet<int> visited = new();
    private HashSet<int> currentVisits = new();
    private List<int> Result = new List<int>();

    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        foreach (var pr in prerequisites) {
            if (!preMap.ContainsKey(pr[0])) {
                preMap[pr[0]] = new List<int>();
            }

            preMap[pr[0]].Add(pr[1]);
        }

        for (int i = 0; i < numCourses; i++) {
            if (preMap.ContainsKey(i) && preMap[i].Count > 0) {
                currentVisits = new();
                if (DFS(i)) {
                    return [];
                }
            } else if (!visited.Contains(i)) {
                visited.Add(i);
                Result.Add(i);
            }
        }

        return Result.Count == numCourses ? Result.ToArray() : [];
    }

    public bool DFS(int i) {
        currentVisits.Add(i);

        foreach (var pr in preMap[i]) {
            if (currentVisits.Contains(pr)) {
                return true;
            }

            if (preMap.ContainsKey(pr) && preMap[pr].Count > 0) {
                if (DFS(pr)) {
                    return true;
                }
            } else if (!visited.Contains(pr)) {
                visited.Add(pr);
                Result.Add(pr);
            }
        }

        currentVisits.Remove(i);
        preMap[i].Clear();
        if (!visited.Contains(i)) {
            visited.Add(i);
            Result.Add(i);
        }
        return false;
    }
}
