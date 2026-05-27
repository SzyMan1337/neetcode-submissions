public class Solution {
    public List<int> MajorityElement(int[] nums) {
        int n = nums.Length;
        var dict = new Dictionary<int,int>();

        foreach(var num in nums){
            if(dict.ContainsKey(num)){
                dict[num]++;
                continue;
            }

            if(dict.Count == 2){
                var keys = dict.Keys.ToList();
                foreach(var key in keys){
                    dict[key]--;
                    if(dict[key]==0){
                        dict.Remove(key);
                    }
                }
                continue;
            }
            dict[num] = 1;
        }

        List<int> res = new List<int>();
        foreach (int candidate in dict.Keys) {
            int freq = 0;
            foreach (int num in nums) {
                if (num == candidate) {
                    freq++;
                }
            }
            if (freq > nums.Length / 3) {
                res.Add(candidate);
            }
        }

        return res;
    }
}