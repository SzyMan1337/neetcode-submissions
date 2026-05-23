public class Solution {
    public int CalPoints(string[] operations) {
        Stack<int> stack = new Stack<int>();
        int res = 0;

        foreach (var op in operations) {
            if (op == "+") {
                int top = stack.Pop();
                int second = stack.Peek();
                int sum = top + second;
                stack.Push(top);
                stack.Push(sum);
                res += sum;
            } else if (op == "D") {
                int doubleVal = 2 * stack.Peek();
                stack.Push(doubleVal);
                res += doubleVal;
            } else if (op == "C") {
                res -= stack.Pop();
            } else {
                int num = int.Parse(op);
                stack.Push(num);
                res += num;
            }
        }

        return res;
    }
}