public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        var result = new int[n];
        var stack = new Stack<int>();
        stack.Push(n-1);

        result[n-1]= 0;

        for(int i = n-2; i >= 0; i--)
        {
            while(stack.Count > 0 && temperatures[stack.Peek()] <= temperatures[i])
            {
                stack.Pop();
            }

            result[i] = stack.Count >0 ? stack.Peek() - i:0;
            stack.Push(i);
        }
        return result;
    }
}
