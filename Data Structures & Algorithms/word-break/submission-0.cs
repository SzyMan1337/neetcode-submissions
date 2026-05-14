public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        int n = s.Length;
        var dp = new bool[s.Length+1];
        dp[s.Length]=true;

        for(int i = n-1; i>=0;i--){
            foreach(var word in wordDict){
                if(i+word.Length <=n && word == s[i..(i+word.Length)]){
                    dp[i] = dp[i+word.Length];

                    if(dp[i]){
                        break;
                    }
                }
            }
        }

        return dp[0];
    }
}
