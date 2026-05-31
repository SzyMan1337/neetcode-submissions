public class Solution {
    public int MinExtraChar(string s, string[] dictionary) {
        var root = new TrieNode();

        foreach(var d in dictionary){
            AddWord(root,d);
        }

        int n = s.Length;
        int[] dp = new int[n + 1];

        for(int i = n-1; i >= 0; i--){
            dp[i] = 1 + dp[i+1];

            var curr = root;

            for(int j =i; j<n; j++){
                int idx = s[j] -'a';
                if(curr.Children[idx] == null){
                    break;
                }

                curr = curr.Children[idx];
                if(curr.EndOfWord){
                    dp[i] = Math.Min(dp[i], dp[j+1]);
                }
            }
        }

        return dp[0];
    }

    private void AddWord(TrieNode root, string d){
        var node = root;

        foreach(var c in d){
            if(node.Children[c-'a'] == null){
                node.Children[c-'a'] = new TrieNode();
            }

            node = node.Children[c-'a'];
        }

        node.EndOfWord = true;
    }
}

public class TrieNode
{
    public bool EndOfWord = false;
    public TrieNode[] Children;

    public TrieNode(){
        Children = new TrieNode[26];
    }
}