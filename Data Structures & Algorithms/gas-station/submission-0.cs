public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        if (gas.Sum() < cost.Sum()) {
            return -1;
        }

        int currentMin = int.MaxValue;
        int currentMinIndex = -1;
        int total = 0;

        for(int i =0; i<gas.Length; i++){
            total += (gas[i] - cost[i]);

            if(total <= currentMin){
                currentMinIndex = i;
                currentMin = total;
            }
        }

        return (currentMinIndex+1)%gas.Length;
    }
}