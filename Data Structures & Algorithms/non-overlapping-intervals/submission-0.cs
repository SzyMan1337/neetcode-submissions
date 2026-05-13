public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a,b) => a[0].CompareTo(b[0]));

        var counter = 0;
        var currentEnd =intervals[0][1];

        for(int i =1; i< intervals.Length; i++){
            if(currentEnd > intervals[i][0]){
                currentEnd = Math.Min(currentEnd, intervals[i][1]);
                counter++;
                continue;
            }

            currentEnd = intervals[i][1];
        }
        return counter;
    }
}
