public class FreqStack {
    private Dictionary<int, int> cnt;
    private Dictionary<int, Stack<int>> stacks;
    private int maxCnt;

    public FreqStack() {
        cnt = new Dictionary<int, int>();
        stacks = new Dictionary<int, Stack<int>>();
        maxCnt = 0;
    }
    
    public void Push(int val) {
        if(!cnt.ContainsKey(val)){
            cnt[val] = 0;
        }

        cnt[val]++;

        if(cnt[val] >maxCnt){
            maxCnt = cnt[val];
            stacks[maxCnt] = new Stack<int>();
        }
        stacks[cnt[val]].Push(val);
    }
    
    public int Pop() {
        if(maxCnt == 0){
            return -1;
        }

        var p = stacks[maxCnt].Pop();
        cnt[p]--;

        if(stacks[maxCnt].Count == 0){
            maxCnt--;
        }

        return p;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */