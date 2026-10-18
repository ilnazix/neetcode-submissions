public class MinStack {
    private Stack<int> mainStack;
    private Stack<int> minStack;

    public MinStack() {
        mainStack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        mainStack.Push(val);
        
        if(minStack.Count == 0){
            minStack.Push(val); return;
        }

        var prevMin = minStack.Peek();
        minStack.Push(Math.Min(prevMin, val));
    }
    
    public void Pop() {
        minStack.Pop();
        mainStack.Pop();
    }
    
    public int Top() {
        return mainStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
