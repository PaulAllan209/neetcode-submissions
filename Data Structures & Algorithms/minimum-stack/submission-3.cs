public class MinStack {
    private Stack<int> mainStack = new();
    private Stack<int> minStack = new();

    public MinStack() {
        
    }
    
    public void Push(int val) {
        mainStack.Push(val);
        val = Math.Min(val, minStack.Count == 0 ? val : minStack.Peek());
        minStack.Push(val);
    }
    
    public void Pop() {
        mainStack.Pop();
        minStack.Pop();
    }
    
    public int Top() {
        return mainStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();
    }
}
