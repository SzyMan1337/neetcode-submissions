public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int n = numbers.Length;
        int l =0, r = n-1;

        while(l < r)
        {
            int sum = numbers[l] + numbers[r];
            if(target == sum)
            {
                return [l+1, r+1];
            }
            else if(sum > target)
            {
                r--;
            }
            else
            {   
                l++;
            }
        }

        return [l+1, r+1];
    }
}
