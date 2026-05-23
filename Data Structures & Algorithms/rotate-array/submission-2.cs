public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k %= n;

        int count = 0;

        for (int start = 0; count < n; start++) {
            int current = start;
            int prev = nums[start];

            do {
                int next = (current + k) % n;
                int temp = nums[next];

                nums[next] = prev;
                prev = temp;
                current = next;

                count++;
            } while (current != start);
        }
    }
}