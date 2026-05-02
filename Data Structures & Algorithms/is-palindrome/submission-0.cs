public class Solution {
    public bool IsPalindrome(string s) {
        var n = s.Length;

        int r= n-1, l =0;

        while(l<r){
            while (l < r && !AlphaNum(s[l])) {
                l++;
            }
            while (r > l && !AlphaNum(s[r])) {
                r--;
            }

            if (char.ToLower(s[l]) != char.ToLower(s[r])) {
                return false;
            }

            l++; r--;
        }
        return true;
    }

    public bool AlphaNum(char c) {
        return (c >= 'A' && c <= 'Z' ||
                c >= 'a' && c <= 'z' ||
                c >= '0' && c <= '9');
    }
}
