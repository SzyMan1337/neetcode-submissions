public class StockSpanner {
    private Stack<(int price, int span)> stack;

    public StockSpanner() {
        stack = new Stack<(int price, int span)>();
    }
    
    public int Next(int price) {
        int sum =1;

        while(stack.Count >0 && stack.Peek().price <= price)
        {
            sum += stack.Pop().span;
        }
        stack.Push((price,sum));

        return sum;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */