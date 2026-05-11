public class Solution {
    public List<List<string>> Partition(string s) {
        var result = new List<List<string>>();
        Dfs(result, new List<string>(), 0, s);
        return result;
    }

    public void Dfs(List<List<string>> result, List<string> currentPartition, int i, string s)
    {
        if(i==s.Length){
            result.Add(new(currentPartition));
            return;
        }

        for(int j=i;j<s.Length; j++){
            if(IsPalindrome(s,i,j)){
                currentPartition.Add(s.Substring(i,j-i+1));
                Dfs(result, currentPartition, j+1, s);
                currentPartition.RemoveAt(currentPartition.Count -1);
            }
        }
    }

    public bool IsPalindrome(string s, int l, int r){
        while(l<r){
            if(s[l] != s[r]){
                return false;
            }
            l++;
            r--;
        }
        return true;
    }
}