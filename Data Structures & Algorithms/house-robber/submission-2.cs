public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 1){
            return nums[0];
        }

        for(int i =nums.Length-3; i>=0; i--){
            nums[i] = Math.Max(nums[i]+nums[i+2], nums[i+1]);
        }

        return Math.Max(nums[0], nums[1]);
    }
}
