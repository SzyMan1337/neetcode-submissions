public class Solution {
    public int CountSubstrings(string s) {
        int counter = 0;

        for(int i =0;i<s.Length; i++){
            counter += CountPali(i, i, s);
            counter += CountPali(i, i+1, s);
        }

        return counter;
    }

    private int CountPali(int l, int r, string s){
        if(l < 0 || r >= s.Length || s[r] != s[l]){
            return 0;
        }

        return 1 + CountPali(l-1, r+1, s);
    }
}
