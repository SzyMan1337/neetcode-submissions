public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        var result = new List<int[]>();
        
        result.Add(intervals[0]);

        for(int i =1; i<intervals.Length;i++){
            if(result.Last()[1] < intervals[i][0]){
                result.Add(intervals[i]);
            }else{
                result.Last()[1] = Math.Max(result.Last()[1], intervals[i][1]);
            }
        }

        return result.ToArray();
    }
}
