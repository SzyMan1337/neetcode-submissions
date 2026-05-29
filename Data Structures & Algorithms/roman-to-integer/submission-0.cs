public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> roman = new Dictionary<char, int> {
            {'I', 1}, {'V', 5}, {'X', 10},
            {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
        };

        int result = 0;
        int curMax = 1;

        for(int i=s.Length-1; i>=0;i--){
            int num = roman[s[i]];
            if(num<curMax){
                result-=num;
            }else{
                curMax = num;
                result+=num;
            }
        }
        
        return result;
    }
}