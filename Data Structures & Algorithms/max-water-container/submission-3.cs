public class Solution {
    public int MaxArea(int[] heights) {
        int maxArea = 0;
        int n = heights.Length;
        int l =0, r=n-1;

        while(l< r)
        {
            int currentArea = Math.Min(heights[l], heights[r]) * (r-l);
            maxArea = Math.Max(maxArea, currentArea);

            if(heights[l] < heights[r]){
                l++;
            }
            else{
                r--;
            }
        }

        return maxArea;
    }
}
