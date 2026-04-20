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
        ListNode? p1 = head;
        ListNode? p2 = head;

        while (p1 != null && p2 != null) {
            p1 = p1?.next;
            p2 = p2?.next?.next;

            if (p1 == null || p2 == null) {
                return false;
            }
            else if (p1 == p2) {
                return true;
            }
        }
        return false;
    }
}
