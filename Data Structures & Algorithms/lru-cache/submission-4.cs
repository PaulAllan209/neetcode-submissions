#nullable enable

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
    int cap;
    Node left = new();
    Node right = new();

    Dictionary<int, Node> values = new();

    public LRUCache(int capacity) {
        cap = capacity;
        left.next = right;
        right.prev = left;
    }
    
    public int Get(int key) {
        if (values.ContainsKey(key)) {
            var node = values[key];
            Remove(node);
            Insert(node);
            return node.val;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (values.ContainsKey(key)) {
            var node = values[key];
            Remove(node);
            Insert(node);
            node.val = value;
        }
        else {
            var node = new Node(value, key);
            Insert(node);
            values[key] = node;
        }

        if (values.Count > cap) {
            var first = left.next;
            var next = first.next;
            left.next = next;
            next.prev = left;
            values.Remove(first.key);
        }
    }

    private void Remove(Node node) {
        var next = node.next;
        var prev = node.prev;
        prev.next = next;
        next.prev = prev;
    }

    private void Insert(Node node) {
        var last = right.prev;
        last.next = node;
        right.prev = node;
        node.next = right;
        node.prev = last;
    }
    
}
