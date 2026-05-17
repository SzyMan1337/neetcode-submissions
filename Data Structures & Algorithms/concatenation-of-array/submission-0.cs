public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;

        var ans = new int[2*n];

        for(int i=0; i<n;i++){
            ans[i] = ans[n+i] = nums[i];
        }

        return ans;
    }
}