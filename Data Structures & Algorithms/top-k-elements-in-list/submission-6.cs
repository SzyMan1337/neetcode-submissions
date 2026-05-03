public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var countNumbers = new Dictionary<int, int>();
        var result = new int[k];

        List<int>[] freq = new List<int>[nums.Length + 1];
        for (int i = 0; i < freq.Length; i++) {
            freq[i] = new List<int>();
        }

        foreach(var num in nums)
        {
            if (!countNumbers.ContainsKey(num))
            {
                countNumbers[num] = 0;
            }
            countNumbers[num]++;
        }

        foreach(var (num, count) in countNumbers)
        {
            freq[count].Add(num);
        }

        int found = 0;
        for(int i = nums.Length; i >= 0 && found < k; i--)
        {
            foreach (int p in freq[i]) {
                result[found++] = p;
            }
        }

        return result;
    }
}
