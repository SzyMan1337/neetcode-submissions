public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        var fromL = new int[n];
        var fromR = new int[n];

        fromL[0] = nums[0];
        fromR[0] = nums[n-1]; 

        for(int i =1;i<n; i++){
            fromL[i] = nums[i]*fromL[i-1];
            fromR[i] = nums[n-i-1]*fromR[i-1];
        }

        var result = new int[n];
        result[0] = fromR[n-2];
        result[n-1] = fromL[n-2];
        for(int i =1; i<n-1;i++){
            result[i] = fromR[n-2-i]*fromL[i-1];
        }

        return result;
    }
}
