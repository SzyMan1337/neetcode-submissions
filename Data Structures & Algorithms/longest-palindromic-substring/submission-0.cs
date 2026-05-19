public class Solution {
    public string LongestPalindrome(string s) {
        int resLen = 0, resIndex = 0;

        for (int i = 0; i < s.Length; i++) {
            int l = i, r = i;

            while (l >= 0 && r < s.Length && s[l] == s[r]) {
                if (r - l + 1 > resLen) {
                    resLen = r - l + 1;
                    resIndex = l;
                }

                r++;
                l--;
            }

            r = i + 1;
            l = i;
            while (l >= 0 && r < s.Length && s[l] == s[r]) {
                if (r - l + 1 > resLen) {
                    resLen = r - l + 1;
                    resIndex = l;
                }

                r++;
                l--;
            }
        }

        return s.Substring(resIndex, resLen);
    }
}
