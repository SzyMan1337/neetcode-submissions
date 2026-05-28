public class Solution {
    public int SplitArray(int[] nums, int k) {
        int l = nums.Max();
        int r = nums.Sum();

        while (l < r) {
            int m = (l + r) / 2;

            bool isValid = CheckIfValid(nums, k, m);

            if (isValid) {
                r = m;
            } else {
                l = m + 1;
            }
        }
        return r;
    }

    public bool CheckIfValid(int[] nums, int k, int m) {
        int curSum = 0;

        foreach (var num in nums) {
            if (curSum + num > m) {
                curSum = 0;
                k--;
            }
            curSum += num;
        }

        return k > 0;
    }
}