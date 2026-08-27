#nullable enable

public class Node {
    public int val = 0;
    public int key = 0;
    public Node? left = null;
    public Node? right = null;

    public Node() {
        
    }
}
public class LRUCache {
    Node r = new();
    Node l = new();
    Dictionary<int, Node> values = new();
    int cap;

    public LRUCache(int capacity) {
        cap = capacity;
        l.right = r;
        r.left = l;
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
            node.val = value;
            Remove(node);
            Insert(node);
        }
        else {
            Node node = new();
            node.key = key;
            node.val = value;
            values[key] = node;
            Insert(node);
        }

        if (values.Count > cap) {
            var last = l.right;
            if (last != null) {
                var right = last.right;
                right.left = l;
                l.right = right;
                Remove(last);
                values.Remove(last.key);
            }
        }
    }

    public void Insert(Node node) {
        var last = r.left;
        if (last == null) return;

        r.left = node;
        last.right = node;
        node.left = last;
        node.right = r;
    }

    public void Remove(Node node) {
        var left = node.left;
        var right = node.right;

        if (left == null || right == null) return;

        left.right = right;
        right.left = left;
    }
}
