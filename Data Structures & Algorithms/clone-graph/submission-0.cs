/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    private Node res;
    private Queue<Node> q = new();
    private Dictionary<Node, Node> seen = new();

    public Node CloneGraph(Node node) {
        if (node == null) return null;

        bfs(node);
        return res;
    }

    private void bfs(Node node) {
        res = new(node.val);
        seen[node] = res;
        q.Enqueue(node);

        while (q.Count > 0) {
            var popped = q.Dequeue();
            var curr = seen[popped];

            foreach (var item in popped.neighbors) {
                if (!seen.ContainsKey(item)) {
                    var newNode = new Node(item.val);
                    curr.neighbors.Add(newNode);
                    seen[item] = newNode;
                    q.Enqueue(item);
                }
                else {
                    curr.neighbors.Add(seen[item]);
                }
            }
        }
    }
}
