public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numbers = [.. nums];
        HashSet<int> visited = new HashSet<int>();

        int longest = 0;
        foreach (int num in numbers)
        {
            if (!visited.Contains(num))
            {
                visited.Add(num);
                int currentLength = 1;

                int left = num - 1;
                while (numbers.Contains(left))
                {
                    visited.Add(left);
                    currentLength++;
                    left--;
                }

                int right = num + 1;
                while (numbers.Contains(right))
                {
                    visited.Add(right);
                    currentLength++;
                    right++;
                }

                longest = Math.Max(longest, currentLength);
            }
        }

        return longest;
    }
}
