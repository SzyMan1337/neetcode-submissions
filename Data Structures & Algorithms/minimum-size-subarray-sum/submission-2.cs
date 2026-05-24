public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int n = nums.Length;

        int l =0;
        int r =1;
        int minLength = int.MaxValue;
        int sum = nums[0];

        while(r <n){
            if(sum >= target){
                minLength = Math.Min(r-l,minLength);
                sum -= nums[l];
                l++;
            }else{
                sum+=nums[r];
                r++;
            }
        }

        while(sum >= target){
            minLength = Math.Min(r-l,minLength);
            sum -= nums[l];
            l++;
        }

        return minLength == int.MaxValue? 0:minLength;
    }
}