public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length)
            return false;

        Dictionary<char, int> letters = new Dictionary<char, int>();

        foreach(var c in s){
            if(letters.ContainsKey(c)) letters[c]++;
            else letters[c] = 1;
        }
        
        foreach(var l in t){
            if(!letters.ContainsKey(l) || letters[l] == 0){
                return false;
            }
            letters[l]--;
        }

        return true;
    }
}

