public class MinStack {
    Stack<int> min = new();
    Stack<int> store = new();

    public MinStack() {
        
    }
    
    public void Push(int val) {
        store.Push(val);
        if (min.Count == 0) {
            min.Push(val);
        }
        else if (min.Peek() >= val) {
            min.Push(val);
        }
    }
    
    public void Pop() {
        var popped = store.Pop();

        if (min.Peek() == popped) {
            min.Pop();
        }
    }
    
    public int Top() {
        return store.Peek();
    }
    
    public int GetMin() {
        return min.Peek();
    }
}
