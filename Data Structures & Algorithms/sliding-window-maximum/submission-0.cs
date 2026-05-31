public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        int[] output = new int[n - k + 1];

        var deque = new LinkedList<int>();

        for (int i = 0; i < k; i++) {
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i]) {
                deque.RemoveLast();
            }

            deque.AddLast(i);
        }

        output[0] = nums[deque.First.Value];
        for (int right = k; right < n; right++) {
            int left = right - k + 1;

            if (deque.Count > 0 && deque.First.Value < left) {
                deque.RemoveFirst();
            }

            while (deque.Count > 0 && nums[deque.Last.Value] < nums[right]) {
                deque.RemoveLast();
            }

            deque.AddLast(right);
            output[left] = nums[deque.First.Value];
        }

        return output;
    }
}
