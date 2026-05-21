public class Solution {
    public int MajorityElement(int[] nums) {
        int majorEl = nums[0];
        int count = 0;

        foreach(var num in nums){
            count += majorEl == num? 1:-1;

            if(count <0){
                majorEl = num;
                count =1;
            }
        }
        return majorEl;





        // int num =0, votes=0;

        // for(int i =0;i<nums.Length;i++)
        // {
        //     if(votes==0){
        //         num = nums[i];
        //     }

        //     votes += num == nums[i] ? 1:-1;
        // }
        // return num;
    }
}