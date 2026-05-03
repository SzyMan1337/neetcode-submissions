public class Solution 
{
    public int LargestRectangleArea(int[] heights) 
    {
        var stack = new Stack<(int height, int index)>();
        int largestArea = 0;
        stack.Push((heights[0], 0));

        for(int i =1; i <heights.Length; i++)
        {
            int lastIndex = i;
            while(stack.Count> 0 && heights[i] < stack.Peek().height)
            {
                var (height, index) = stack.Pop();
                var width = i-index;
                var calculatedArea = height * width;
                largestArea = int.Max(largestArea, calculatedArea);
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
            var width = heights.Length - index;
            var calculatedArea = height * width;
            largestArea = int.Max(largestArea, calculatedArea);
        }

        return largestArea;
    }
}
