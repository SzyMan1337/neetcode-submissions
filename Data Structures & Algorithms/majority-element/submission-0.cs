public class Solution {
    public int MajorityElement(int[] nums) {
        int num =0, votes=0;

        for(int i =0;i<nums.Length;i++)
        {
            if(votes==0){
                num = nums[i];
            }

            votes += num == nums[i] ? 1:-1;
        }
        return num;
    }
}