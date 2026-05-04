public class Solution {
    public int FindMin(int[] nums) {
        int n = nums.Length;
        int left = 0, right = n - 1;

        while(left < right)
        {
            int mid = (left + right) / 2;
            if(nums[mid] > nums[right])
            {
                left = mid +1;
            }
            else
            {
                right = mid;
            }
        }

        return nums[left];
    }
}
