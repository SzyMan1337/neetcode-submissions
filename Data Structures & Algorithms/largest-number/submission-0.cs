public class Solution {
    public string LargestNumber(int[] nums) {
        string[] arr = new string[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            arr[i] = nums[i].ToString();
        }

        Array.Sort(arr, (a,b)=> {
            string order1 = a + b;
            string order2 = b + a;
            return order2.CompareTo(order1);
        });

        string result = string.Join("", arr);
        return result[0] == '0' ? "0" : result;
    }
}