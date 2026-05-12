public class Solution {
    public int MaxProduct(int[] nums) {
        int result = int.MinValue;
        int curMin = 1, curMax=1;

        foreach(var num in nums){
            if(num ==0){
                curMin=1;
                curMax=1;
                result = Math.Max(result,0);
                continue;
            }

            var temp = curMax*num;
            var temp2 = curMin*num;
            curMin = Math.Min(num, Math.Min(temp2, temp));
            curMax = Math.Max(num, Math.Max(temp2, temp));

            result = Math.Max(result, curMax);
        }

        return result;
    }
}
