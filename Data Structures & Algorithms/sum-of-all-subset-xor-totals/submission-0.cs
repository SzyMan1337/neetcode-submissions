public class Solution {
    public int SubsetXORSum(int[] nums) {
        if(nums.Length == 0) return 0;

        int result = Backtrack(nums, 1, nums[0]) + Backtrack(nums, 1, 0);

        return result;
    }

    public int Backtrack(int[] nums, int i, int xor){
        if(i == nums.Length){
            return xor;
        }

        int tmp = xor ^ nums[i];

        return Backtrack(nums, i+1, xor) + Backtrack(nums, i+1, tmp);
    }
}