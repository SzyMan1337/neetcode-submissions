public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var result = new List<List<int>>();
        Backtrack(nums, 0, result);

        return result;    
    }   

    private void Backtrack(int[] nums, int idx, List<List<int>> result)
    {
        if(idx == nums.Length){
            result.Add(new(nums));
            return;
        }

        for(int j = idx; j<nums.Length; j++){
            Swap(nums, j, idx);
            Backtrack(nums, idx+1, result);
            Swap(nums, idx, j);
        }
    }

    private void Swap(int[] nums, int idx1, int idx2){
        var temp = nums[idx1];
        nums[idx1] = nums[idx2];
        nums[idx2]= temp;
    }
}
