public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length ==0){
            return "";
        }

        string commonPrefix = "";
        int lengthOfCommonPrefix = 0;
        while(true)
        {
            if(strs[0].Length <= lengthOfCommonPrefix){
                return commonPrefix;
            }

            char c = strs[0][lengthOfCommonPrefix];
            foreach(var s in strs){
                if(s.Length <= lengthOfCommonPrefix || s[lengthOfCommonPrefix] != c){
                    return commonPrefix;
                }
            }

            commonPrefix+=c;
            lengthOfCommonPrefix++;
        }

        return commonPrefix;
    }
}