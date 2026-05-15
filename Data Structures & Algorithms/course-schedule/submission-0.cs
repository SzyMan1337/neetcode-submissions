public class Solution {
    // Map each course to its prerequisites
    private Dictionary<int, List<int>> preMap = new Dictionary<int, List<int>>();
    // Store all courses along the current DFS path
    private HashSet<int> visiting = new HashSet<int>();


    public bool CanFinish(int numCourses, int[][] prerequisites) {
        foreach(var preq in prerequisites){
            if(!preMap.ContainsKey(preq[0])){
                preMap.Add(preq[0], new List<int>());
            }
            preMap[preq[0]].Add(preq[1]);
        }

        for(int i =0;i<numCourses;i++){
            if(preMap.ContainsKey(i) && preMap[i].Count >0){
                if(!DFS(i)){
                    return false;
                }
            }
            
        }

        return true;
    }

    public bool DFS(int i){
        visiting.Add(i);

        foreach(var pr in preMap[i]){
            if(visiting.Contains(pr)){
                return false;
            }
            
            if(preMap.ContainsKey(pr) && !DFS(pr)){
                return false;
            }
        }
        
        visiting.Remove(i);
        preMap[i].Clear();
    
        return true;
    }
}
