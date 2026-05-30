public class Solution {
    public string DecodeString(string s) {
        var stack = new Stack<int>();
        var stackString = new Stack<string>();

        int i =0;
        int n = s.Length;
        var sb =new StringBuilder();

        while(i<n){
            if(char.IsDigit(s[i])){
                int digitLength = 1;

                while(char.IsDigit(s[i+digitLength])){
                    digitLength++;
                }

                int num = int.Parse(s[i..(i+digitLength)]);

                stack.Push(num);
                stackString.Push(sb.ToString());
                sb = new StringBuilder();
                i += digitLength+1;
                continue;
            }

            if(s[i] == ']'){
                int num = stack.Pop();
                var prevS = stackString.Pop();
                var newSb = new StringBuilder();
                string curString = sb.ToString();
                newSb.Append(prevS);

                for(int j =0; j<num; j++){
                    newSb.Append(curString);
                }
                sb = newSb;
            }else{
                sb.Append(s[i]);
            }
            i++;
        }

        return sb.ToString();
    }
}