public class Solution {
    public int EvalRPN(string[] tokens) {
        int result = 0;
        var stack = new Stack<int>();

        foreach(var token in tokens)
        {
            if(int.TryParse(token, out int num))
            {
                stack.Push(num);
            }
            else
            {
                var num1 = stack.Pop();
                var num2 = stack.Pop();
                
                switch(token)
                {
                    case "+":
                        result = num2+num1;
                        break;
                    case "-":
                        result = num2-num1;
                        break;
                    case "/":
                        result = num2/num1;
                        break;
                    case "*":
                        result = num2*num1;
                        break;
                }
                stack.Push(result);
            }
        }

        if(stack.Count >0)
        {
            return stack.Pop();
        }

        return result;
    }
}
