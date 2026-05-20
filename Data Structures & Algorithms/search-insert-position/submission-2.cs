public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l =0, r=nums.Length;

        while(l<r){
            int m =(l+r)/2;

            if(nums[m] == target){
                return m;
            }else if(nums[m] <target){
                l=m+1;
            }else{
                r=m;
            }
        }
        return r;
    }
}