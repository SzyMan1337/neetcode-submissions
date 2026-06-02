public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Dictionary<int, int> nums1Idx = new Dictionary<int, int>();

        for (int i = 0; i < nums1.Length; i++) {
            nums1Idx[nums1[i]] = i;
        }

        int[] res = new int[nums1.Length];
        Array.Fill(res, -1);

        Stack<int> stack = new Stack<int>();

        for (int i = nums2.Length - 1; i >= 0; i--) {
            while (stack.Count > 0 && stack.Peek() <= nums2[i]) {
                stack.Pop();
            }

            if (nums1Idx.ContainsKey(nums2[i])) {
                int insertIdx = nums1Idx[nums2[i]];
                res[insertIdx] = stack.Count > 0 ? stack.Peek() : -1;
            }

            stack.Push(nums2[i]);
        }

        return res;
    }
}