public class Solution {
    public List<List<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        var result = new List<List<int>>();
        int i =0;

        while(i< nums.Length-3){
            int num1 = nums[i];

            for(int j =i+1; j<nums.Length-2;j++){
                if(j-1 !=i && nums[j] == nums[j-1]){
                    continue;
                }

                int num2 = nums[j];
                long newTarget = (long)target - num1 - num2;

                int l = j +1;
                int r = nums.Length-1;

                while(l<r){
                    long sum = nums[l]+nums[r];

                    if(newTarget == sum){
                        result.Add(new List<int>() {num1, num2, nums[l], nums[r]});
                        int oldNumR = nums[r];

                        while(r>l && oldNumR == nums[r]){
                            r--;
                        }     
                    }else if(newTarget > sum){
                        l++;
                    }else{
                        r--;
                    }
                }
            }

            while(i<nums.Length-3 && num1 == nums[i]){
                i++;
            }
        }

        return result;
    }
}
