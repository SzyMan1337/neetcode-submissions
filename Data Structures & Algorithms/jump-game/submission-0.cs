public class Solution {
    public bool CanJump(int[] nums) {
        int maxJump = nums[0];
        int i =1;

        while(i<nums.Length){
            if(i > maxJump){
                return false;
            }

            maxJump = Math.Max(maxJump, i+ nums[i]);
            i++;
        }

        return true;
    }
}
