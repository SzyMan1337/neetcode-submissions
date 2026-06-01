public class Solution {
    public string AddBinary(string a, string b) {
        StringBuilder res = new StringBuilder();
        int carry = 0;

        int i = a.Length - 1, j = b.Length - 1;
        while (i >= 0 || j >= 0 || carry > 0) {
            int digitA = i >= 0 ? a[i] - '0' : 0;
            int digitB = j >= 0 ? b[j] - '0' : 0;

            int total = digitA + digitB + carry;
            res.Append(total % 2);
            carry = total / 2;

            i--;
            j--;
        }

        char[] resultArray = res.ToString().ToCharArray();
        Array.Reverse(resultArray);
        return new string(resultArray);
    }
}