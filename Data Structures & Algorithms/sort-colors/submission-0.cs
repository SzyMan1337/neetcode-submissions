public class Solution {
    public void SortColors(int[] nums) {
                int[] count = new int[3];
        foreach (int num in nums) {
            count[num]++;
        }

        int index = 0;
        for (int i = 0; i < 3; i++) {
            while (count[i]-- > 0) {
                nums[index++] = i;
            }
        }
    }
}