public class Solution {
    public bool CanPartition(int[] nums) {
        var sum = nums.Sum();
        if (sum % 2 != 0) return false;
        var target = sum / 2;

        var dp = new HashSet<int>();
        dp.Add(0);

        foreach(var num in nums){
            HashSet<int> nextDP = new HashSet<int>();
            foreach (int t in dp) {
                if (t + num == target) {
                    return true;
                }
                nextDP.Add(t + num);
                nextDP.Add(t);
            }
            dp = nextDP; 
        }

        return dp.Contains(target);
    }
}
