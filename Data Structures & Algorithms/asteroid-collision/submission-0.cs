public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();

        foreach (int a in asteroids) {
            int current = a;
            while (stack.Count > 0 && current < 0 && stack.Peek() > 0) {
                int diff = current + stack.Peek();
                if (diff < 0) {
                    stack.Pop();
                } else if (diff > 0) {
                    current = 0;
                } else {
                    current = 0;
                    stack.Pop();
                }
            }
            if (current != 0) {
                stack.Push(current);
            }
        }

        int[] result = stack.Reverse().ToArray();
        return result;
    }
}