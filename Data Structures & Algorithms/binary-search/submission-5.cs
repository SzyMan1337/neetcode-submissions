public class Solution {
    public int Search(int[] nums, int target) {
        int l =0, r= nums.Length-1;

        while(l < r){
            int m = (l+r)/2;

            if(nums[m] == target)
            {
                return m;
            }
            else if(nums[m] <target)
            {
                l = m + 1;
            }
            else
            {
                r = m - 1;
            }
        }

        return (l < nums.Length && nums[l] == target) ? l : -1;
    }
}
