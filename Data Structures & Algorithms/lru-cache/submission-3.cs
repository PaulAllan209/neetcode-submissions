public class Node {
    public Node? prev = null;
    public Node? next = null;
    public int val;
    public int key;
    
    public Node(int val = 0, int key = 0) {
        this.val = val;
        this.key = key;
    }
}

public class LRUCache {
    private Node left = new();
    private Node right = new();
    private Dictionary<int, Node> nodeKeys = new();
    private int capacity;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        left.next = right;
        right.prev = left;
    }
    
    public int Get(int key) {
        if (nodeKeys.ContainsKey(key)) {
            var node = nodeKeys[key];
            Remove(node);
            Insert(node);

            return node.val;
        }
        return - 1;
    }
    
    public void Put(int key, int value) {
        if (nodeKeys.ContainsKey(key)) {
            var node = nodeKeys[key];
            node.val = value;
            Remove(node);
            Insert(node);
        }
        else {
            var node = new Node(value, key);
            nodeKeys[key] = node;
            Insert(node);
        }

        if (nodeKeys.Count > capacity) {
            var remove = left.next;
            var next = remove.next;
            left.next = next;
            next.prev = left;
            remove.prev = null;
            remove.next = null;
            nodeKeys.Remove(remove.key);
        }
    }

    private void Remove(Node node) {
        var prev = node.prev;
        var next = node.next;
        prev.next = next;
        next.prev = prev;
    }

    private void Insert(Node node) {
        var prev = right.prev;
        right.prev = node;
        node.prev = prev;
        node.next = right;
        prev.next = node;
    }
}
