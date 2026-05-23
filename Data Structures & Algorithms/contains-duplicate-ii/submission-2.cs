public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        int l = 0, r = k <nums.Length? k:nums.Length-1;
        HashSet<int> window = new HashSet<int>();

        for(int i =0;i<=r;i++){
            if(window.Contains(nums[i])){
                return true;
            }
            window.Add(nums[i]);
        }

        while(r<nums.Length-1){
            window.Remove(nums[l]);
            l++;
            r++;
            if(window.Contains(nums[r])){
                return true;
            }
            window.Add(nums[r]);
        }

        return false;
    }
}