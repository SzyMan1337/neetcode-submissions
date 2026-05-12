public class Solution {
    private Dictionary<char, char[]> DigitToChar = new Dictionary<char, char[]> {
        { '2', new char[] { 'a', 'b', 'c' } }, { '3', new char[] { 'd', 'e', 'f' } },
        { '4', new char[] { 'g', 'h', 'i' } }, { '5', new char[] { 'j', 'k', 'l' } },
        { '6', new char[] { 'm', 'n', 'o' } }, { '7', new char[] { 'p', 'q', 'r', 's' } },
        { '8', new char[] { 't', 'u', 'v' } }, { '9', new char[] { 'w', 'x', 'y', 'z' } }
    };

    public List<string> LetterCombinations(string digits) {
        var result = new List<string>();
        if(digits.Length != 0){
            Backtrack(result, digits, 0, new char[digits.Length]);
        }

        return result;
    }

    public void Backtrack(List<string> result, string digits, int i, char[] current){
        if(i == current.Length){
            result.Add(new string(current));
            return;
        }

        var digit = digits[i];
        foreach(var c in DigitToChar[digit]){
            current[i]=c;
            Backtrack(result,digits,i+1,current);
        }
    }
}
