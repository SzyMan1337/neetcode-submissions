public class Solution {
    public bool CanPartitionKSubsets(int[] nums, int k) {
        int sum = nums.Sum();
        if(sum%k != 0){
            return false;
        }
        int goal = sum/k;
        int[] buckets = new int[k];

        bool DFS(int index){
            if(index == nums.Length){
                return true;
            }

            for(int i =0;i<k;i++){
                if(buckets[i] + nums[index] <= goal){
                    buckets[i] += nums[index];
                    if(DFS(index+1)){
                        return true;
                    }
                    buckets[i] -= nums[index];
                }

                if(buckets[i] == 0){
                    break;
                }
            }

            return false;
        }
        
        return DFS(0);
    }
}