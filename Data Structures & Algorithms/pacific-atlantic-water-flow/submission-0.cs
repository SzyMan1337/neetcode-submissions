public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        var canReachPacific = new HashSet<(int,int)>();
        var canReachAtalntic = new HashSet<(int,int)>();
        
        int n = heights.Length;
        int m = heights[0].Length;

        for(int i =0;i<n; i++){
            DFS(canReachPacific, heights, i,0, int.MinValue);
            DFS(canReachAtalntic, heights, i,m-1, int.MinValue);
        }

        for(int j=0; j<m;j++){
            DFS(canReachPacific, heights, 0,j, int.MinValue);
            DFS(canReachAtalntic, heights, n-1,j, int.MinValue);
        }

        var result = new List<List<int>>();
        foreach(var (pR, pC) in canReachPacific)
        {
            if(canReachAtalntic.Contains((pR, pC))){
                result.Add(new List<int>() {
                    pR, pC
                });
            }
        }

        return result;
    }

    public void DFS(HashSet<(int,int)> ocean, int[][] heights, int r, int c, int prevHeight)
    {
        if(ocean.Contains((r,c)) || r < 0 || r>=heights.Length || c< 0 || c >= heights[0].Length
            || prevHeight >heights[r][c]){
            return;
        }

        ocean.Add((r,c));

        DFS(ocean,heights, r-1,c, heights[r][c]);
        DFS(ocean,heights, r+1,c, heights[r][c]);
        DFS(ocean,heights, r,c+1, heights[r][c]);
        DFS(ocean,heights, r,c-1, heights[r][c]);
    }
}
