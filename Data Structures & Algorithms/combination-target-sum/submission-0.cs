public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var result = new List<List<int>>();
        Backtract(result, nums, 0, new List<int>(), target);
        return result;
    }

    public void Backtract(List<List<int>> result, int[] nums, int index, List<int> currentList, int currentTarget)
    {
        if(currentTarget == 0){
            result.Add(new List<int>(currentList));
            return;
        }
        if(currentTarget <0 || index == nums.Length){
            return;
        }

        currentList.Add(nums[index]);
        Backtract(result, nums, index, currentList, currentTarget - nums[index]);
        currentList.RemoveAt(currentList.Count - 1);
        Backtract(result, nums, index +1, currentList, currentTarget);
    }
}
