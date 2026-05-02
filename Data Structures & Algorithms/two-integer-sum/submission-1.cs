public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numbers = new Dictionary<int, int>(); 
        for(int i = 0; i < nums.Length; i++){ 
            int complement = target - nums[i]; 
            if(numbers.ContainsKey(complement)){ 
                return new int[] { numbers[complement], i }; 
            } 
            numbers.Add(nums[i], i); 
        } 
        return new int[] { }; 
    }
}
