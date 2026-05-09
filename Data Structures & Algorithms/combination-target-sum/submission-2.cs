public class Solution
{
    public List<List<int>> CombinationSum(int[] nums, int target)
    {
        var result = new List<List<int>>();
        Array.Sort(nums);
        Backtract(result, nums, 0, new List<int>(), target);
        return result;
    }

    public void Backtract(List<List<int>> result, int[] nums, int index, List<int> currentList, int currentTarget)
    {
        if (currentTarget == 0)
        {
            result.Add([.. currentList]);
            return;
        }

        for (int i = index; i < nums.Length; i++)
        {
            if (nums[i] > currentTarget)
            {
                return;
            }

            currentList.Add(nums[i]);
            Backtract(result, nums, i, currentList, currentTarget - nums[i]);
            currentList.RemoveAt(currentList.Count - 1);
        }
    }
}
