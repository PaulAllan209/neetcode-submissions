/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Dictionary<Node, Node> hashNodes = new Dictionary<Node, Node>();
        Node headRef = head;

        while (headRef != null) {
            hashNodes[headRef] = new Node(headRef.val);
            headRef = headRef.next;
        }

        headRef = head;

        while (headRef != null) {
            Node copy = hashNodes[headRef];

            copy.next = headRef.next != null ? hashNodes[headRef.next] : null;
            copy.random = headRef.random != null ? hashNodes[headRef.random] : null;

            headRef = headRef.next;
        }

        return head != null ? hashNodes[head] : null;
    }
}
