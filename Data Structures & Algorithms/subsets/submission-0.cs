public class Solution
{
    public List<List<int>> Subsets(int[] nums)
    {
        var result = new List<List<int>>();
        Backtrack(nums, new List<int>(), 0, result);

        return result;
    }

    private void Backtrack(int[] nums, List<int> currentList, int index, List<List<int>> result)
    {
        if (index == nums.Length)
        {
            result.Add(new List<int>(currentList));
            return;
        }

        currentList.Add(nums[index]);
        index++;

        Backtrack(nums, currentList, index, result);
        currentList.RemoveAt(currentList.Count - 1);
        Backtrack(nums, currentList, index, result);
    }
}
