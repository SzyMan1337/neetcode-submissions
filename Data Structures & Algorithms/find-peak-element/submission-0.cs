public class Solution {
    public int FindPeakElement(int[] nums) {
        int l =0, r = nums.Length-1;

        while(l<=r){
            int m = (l+r)/2;
            
            if(m>0 && nums[m-1] > nums[m]){
                r=m-1;
            }else if(m<nums.Length-1 && nums[m+1]>nums[m]){
                l=m+1;
            }else{
                return m;
            }
        }
        return -1;
    }
}