public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numbers = [.. nums];

        int longest = 0;
        foreach (int num in numbers)
        {
            if (!numbers.Contains(num-1))
            {
                int currentLength = 1;
                while (numbers.Contains(num + currentLength))
                {
                    currentLength++;
                }

                longest = Math.Max(longest, currentLength);
            }
        }

        return longest;
    }
}
