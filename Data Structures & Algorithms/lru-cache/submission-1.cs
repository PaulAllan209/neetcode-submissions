public class Node {
    public int val { get; set; }
    public int key { get; set; }
    public Node? prev { get; set; } = null;
    public Node? next { get; set; } = null;

    public Node(int key = 0, int value = 0) {
        this.key = key;
        this.val = value;
    }
}

public class LRUCache {
    public int cap;
    public Node left = new();
    public Node right = new();
    public Dictionary<int, Node> cache = new();

    public LRUCache(int capacity) {
        this.cap = capacity;
        left.next = right;
        right.prev = left;
    }

    public void Remove(Node node) {
        var prev = node.prev;
        var next = node.next;
        prev.next = next;
        next.prev = prev;
    }

    public void Insert(Node node) {
        var prev = right.prev;
        var next = right;
        prev.next = node;
        next.prev = node;
        node.prev = prev;
        node.next = next;
    }
    
    public int Get(int key) {
        if (cache.TryGetValue(key, out Node value)) {
            Remove(value);
            Insert(value);
            return value.val;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (cache.TryGetValue(key, out Node nodeValue)) {
            Remove(nodeValue);
            cache.Remove(key);
        }

        cache[key] = new Node(key, value);
        Insert(cache[key]);

        if (cache.Count > cap) {
            var lru = left.next;
            Remove(lru);
            cache.Remove(lru.key);
        }
    }
}
