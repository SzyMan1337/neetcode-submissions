public class Solution 
{
    public int LargestRectangleArea(int[] heights) 
    {
        int n = heights.Length;
        var stack = new Stack<(int height, int index)>();
        int largestArea = 0;

        for(int i =0; i < n; i++)
        {
            int lastIndex = i;
            while(stack.Count> 0 && heights[i] < stack.Peek().height)
            {
                var (height, index) = stack.Pop();
                largestArea = int.Max(largestArea, height * (i-index));
                lastIndex = index;
            }

            if(stack.Count == 0 || heights[i] != stack.Peek().height)
            {
                stack.Push((heights[i], lastIndex));
            }
        }

        while(stack.Count > 0)
        {
            var (height, index) = stack.Pop();
            largestArea = int.Max(largestArea, height * (n - index));
        }

        return largestArea;
    }
}
