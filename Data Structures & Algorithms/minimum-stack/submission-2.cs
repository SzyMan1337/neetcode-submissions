public class MinStack {

    private Stack<int> ControlMin;
    private Stack<int> MainStack;
    private int currentMin;

    public MinStack() {
        MainStack = new Stack<int>();
        ControlMin = new Stack<int>();
        currentMin = int.MaxValue;
    }
    
    public void Push(int val) {
         MainStack.Push(val);
         if(val <= currentMin){
            currentMin = val;
            ControlMin.Push(val);
         }
    }
    
    public void Pop() {
        int val = MainStack.Pop();

        if(val == currentMin){
            ControlMin.Pop();
        }

        if(ControlMin.Count == 0){
            currentMin = int.MaxValue;
        }
        else{
            currentMin = ControlMin.Peek();
        }
    }
    
    public int Top() {
        return MainStack.Peek();
    }
    
    public int GetMin() {
        return ControlMin.Peek();
    }
}
