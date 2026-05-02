public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();

        foreach(var c in s){
            if(c == '(' || c == '{' || c == '['){
                stack.Push(c);
            }
            else{
                if(stack.Count <= 0)
                    return false;
                var b = stack.Pop();

                if((c == ']' && b != '[') ||
                    (c == ')' && b != '(') ||
                    (c == '}' && b != '{'))
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
