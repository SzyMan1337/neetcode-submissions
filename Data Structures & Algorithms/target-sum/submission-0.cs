public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        dict.Add(0, 1);

        for (int i = 0; i < nums.Length; i++) {
            var newDict = new Dictionary<int,int>();

            foreach(var (sum, count) in dict){
                var addNumSum = sum+nums[i];
                if(!newDict.ContainsKey(addNumSum)){
                    newDict.Add(addNumSum,0);
                }

                var substractNumSum = sum-nums[i];
                if(!newDict.ContainsKey(substractNumSum)){
                    newDict.Add(substractNumSum,0);
                }

                newDict[substractNumSum] += count;
                newDict[addNumSum] +=count;
            }
            
            dict = newDict;
        }

        return dict.ContainsKey(target) ? dict[target] : 0;
    }
}
