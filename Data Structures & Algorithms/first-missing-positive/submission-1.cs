public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int n = nums.Length;
        int someNegativeValue = -(n+1);

        for (int i = 0; i < n; i++) {
            if (nums[i] < 0) {
                nums[i] = 0;
            }
        }

        for(int i =0;i<n;i++){
            int idx = Math.Abs(nums[i]) -1;

            if(idx>=0 && idx<n){
                nums[idx] = -Math.Abs(nums[idx]);
                if(nums[idx]==0){
                    nums[idx] = someNegativeValue;
                }
            }
        }

        for(int i =0;i<n;i++){
            if(nums[i]>=0){
                return i+1;
            }
        }

        return n+1;
    }
}