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
    public bool HasCycle(ListNode head) {
        ListNode dum = new();
        dum.next = head;
        ListNode s = dum;
        ListNode f = dum;

        while (f != null && f.next != null) {
            s = s?.next;
            f = f?.next?.next;

            if (s == f) {
                return true;
            }
        }

        return false;
    }
}
