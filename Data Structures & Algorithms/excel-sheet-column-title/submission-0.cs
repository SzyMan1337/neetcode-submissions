public class Solution {
    public string ConvertToTitle(int columnNumber) {
        var sb = new StringBuilder();

        while(columnNumber>0){
            columnNumber--;
            int exc = columnNumber % 26;
            columnNumber/=26;
            sb.Append((char)(exc+'A'));
        }

        char[] arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);
        return new string(arr);    
    }
}