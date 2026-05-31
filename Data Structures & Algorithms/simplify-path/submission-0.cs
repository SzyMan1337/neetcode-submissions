public class Solution {
    public string SimplifyPath(string path) {
        var stack = new Stack<string>();
        var elements = path.Split('/');

        foreach(var el in elements){
            if(string.IsNullOrEmpty(el) || el == "."){
                continue;
            }

            if(el == ".."){
                if(stack.Count >0){
                    stack.Pop();
                }
                continue;
            }

            stack.Push(el);
        }

        var result = new List<string>(stack);
        result.Reverse();
        return "/" + string.Join("/", result);
    }
}