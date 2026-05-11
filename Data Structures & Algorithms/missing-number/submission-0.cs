public class Solution {
    public int MissingNumber(int[] nums) {
        int result = nums.Length;

        for(int i =0;i<nums.Length; i++){
            result ^= i^nums[i];
        }
        return result;
    }
}
