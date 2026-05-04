public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var res = new List<List<int>>();
        
        int i =0;

        while(i < nums.Length-2)
        {
            int neededSum = -nums[i];

            int l=i+1;
            int r=nums.Length-1;
            while(l<r)
            {
                var sum = nums[l] +nums[r];
                if(sum == neededSum)
                {
                    res.Add(new List<int>{nums[i], nums[l], nums[r]});

                    var lastL = nums[l];
                    r--;
                    while (nums[l] == lastL && l < r)
                    {
                        l++;
                    }
                }
                else if (sum < neededSum)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }

            var lastI = nums[i];
            while(nums[i] == lastI && i < nums.Length-2)
            {
                i++;
            }
        }

        return res;
    }
}
