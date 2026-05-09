public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        var result = new List<List<int>>();
        Backtrack(result, nums, 0, new List<int>());

        return result;
    }

    public void Backtrack(List<List<int>> result, int[] nums, int index, List<int> currentList)
    {
        if(index == nums.Length){
            result.Add(new List<int>(currentList));
            return;
        }

        var el = nums[index];
        int i = 0;

        while(index + i < nums.Length && el == nums[index + i]){
            currentList.Add(el);
            i++;
        }

        for(int j = i; j>0;j--){
            Backtrack(result, nums, index+i, currentList);
            currentList.RemoveAt(currentList.Count - 1);
        }
        Backtrack(result, nums, index+i, currentList);
    }
}
