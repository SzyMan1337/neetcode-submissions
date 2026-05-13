public class Solution {
    public int[][] Merge(int[][] intervals) {
        var max = int.MinValue;

        foreach (var interval in intervals) {
            if (interval[0] > max) {
                max = interval[0];
            }
        }

        var dp = new int[max + 1];
        Array.Fill(dp, -1);

        foreach (var interval in intervals) {
            int start = interval[0];
            int end = interval[1];

            dp[start] = Math.Max(dp[start], end);
        }

        int currentIntervalStart = -1, currentIntervalEnd = -1;
        var result = new List<int[]>();

        for (int i = 0; i <= max; i++) {
            if (dp[i] >= 0) {
                if (currentIntervalStart <0) {
                    currentIntervalStart = i;
                }
                currentIntervalEnd = Math.Max(dp[i], currentIntervalEnd);
            }

            if (i == currentIntervalEnd) {
                result.Add(new int[] { currentIntervalStart, currentIntervalEnd });
                currentIntervalStart = -1;
                currentIntervalEnd = -1;
            }
        }
        if(currentIntervalEnd >= 0){
            result.Add(new int[] { currentIntervalStart, currentIntervalEnd });
        }

        return result.ToArray();
    }

    // public int[][] Merge(int[][] intervals) {
    //     Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
    //     var result = new List<int[]>();

    //     result.Add(intervals[0]);

    //     for(int i =1; i<intervals.Length;i++){
    //         if(result.Last()[1] < intervals[i][0]){
    //             result.Add(intervals[i]);
    //         }else{
    //             result.Last()[1] = Math.Max(result.Last()[1], intervals[i][1]);
    //         }
    //     }

    //     return result.ToArray();
    // }
}
