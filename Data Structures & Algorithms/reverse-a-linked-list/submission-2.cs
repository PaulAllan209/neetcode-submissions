/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null) return head;

        ListNode? refNode = head;
        ListNode? prev = null;

        while (refNode != null) {
            var temp = refNode.next;
            refNode.next = prev;
            prev = refNode;
            refNode = temp;
        }

        return prev;

    }
}
