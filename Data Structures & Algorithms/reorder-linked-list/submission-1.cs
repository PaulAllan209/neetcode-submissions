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
    public void ReorderList(ListNode head) {
        ListNode s = head;
        ListNode f = head.next;

        while (f != null && f.next != null) {
            s = s.next;
            f = f.next.next;
        }

        ListNode? curr = s.next;
        s.next = null;
        ListNode? prev = null;

        while (curr != null) {
            var tmp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = tmp;
        }

        ListNode currHead = head;
        // ListNode? prev1 = null;
        // ListNode? prev2 = null;
        f = prev;

        while (currHead != null && f != null) {
            var tmp1 = currHead.next;
            var tmp2 = f.next;

            currHead.next = f;
            f.next = tmp1;
            currHead = tmp1;
            f = tmp2;
        }
    }
}
