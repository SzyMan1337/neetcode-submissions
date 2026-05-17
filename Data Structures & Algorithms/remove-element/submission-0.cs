public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k =0, i =0;
        int n = nums.Length;

        while(i <n-k)
        {
            if(nums[i] == val)
            {
                nums[i] = nums[n-k-1];
                k++;
                continue;
            }

            i++;
        }
        return n-k;
    }
}