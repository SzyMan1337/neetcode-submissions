public class Solution {
    public int MaxSubArray(int[] nums) {
        int largestSum = nums[0];
        int sum = 0;

        for(int i =0; i<nums.Length;i++){
            sum += nums[i];

            if(largestSum < sum){
                largestSum = sum;
            }

            if(sum<0){
                sum=0;
            }
        }

        return largestSum;
    }
}
