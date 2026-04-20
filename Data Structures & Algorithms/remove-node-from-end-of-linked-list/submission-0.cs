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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dum = new ListNode(next: head);
        ListNode l = dum;
        ListNode r = head;

        for (int i = 0; i < n; i++) {
            r = r.next;
        }

        while (r != null) {
            l = l.next;
            r = r.next;
        }

        l.next = l.next.next;

        return dum.next;
    }
}
