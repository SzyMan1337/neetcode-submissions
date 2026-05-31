public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int left = BinarySearch(nums, target, true);
        int right = BinarySearch(nums, target, false);
        return new int[] { left, right };
    }

    private int BinarySearch(int[] nums, int target, bool leftBias) {
        int l =0 , i =-1;
        int r = nums.Length-1;

        while(l<=r){
            int m = l + (r - l) / 2;

            if(nums[m] == target){
                i=m;
                if(leftBias){
                    r=m-1;
                }else{
                    l=m+1;
                }
            }else if(nums[m] >target){
                r=m-1;
            }else{
                l=m+1;
            }
        }

        return i;
    }
}