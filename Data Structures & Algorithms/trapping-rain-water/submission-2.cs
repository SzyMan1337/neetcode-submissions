public class Solution {
    public int Trap(int[] height) 
    {
        if(height == null || height.Length < 3) return 0;

        int l = 1, r = height.Length - 2;
        int maxL = height[0], maxR = height[height.Length - 1];
        int sum = 0;

        while(l<=r)
        {
            var min = Math.Min(maxL, maxR);

            if(maxL > maxR)
            {
                sum += Math.Max(0, min - height[r]);
                maxR = Math.Max(maxR, height[r]);
                r--;
            }
            else
            { 
                sum += Math.Max(0, min - height[l]);
                maxL = Math.Max(maxL, height[l]);
                l++;
            }
        }

        return sum;
    }
}
