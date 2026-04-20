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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int? carryOver = null;
        ListNode res = new ListNode();
        ListNode retRef = res;
        while (l1 != null || l2 != null || carryOver != 0) {
            int tmp = 0;
            int carry = carryOver ?? 0;

            if (l1 != null && l2 != null) {
                tmp = carry + l1.val + l2.val;
            }
            else if (l1 != null) {
                tmp = carry + l1.val;
            }
            else if (l2 != null) {
                tmp = carry + l2.val;
            }
            else {
                tmp = carry;
            }
            carryOver = 0;
            if (tmp >= 10) {
                carryOver++;
                tmp = tmp - 10;
            }

            res.next =  new ListNode(tmp);
            res = res.next;
            if (l1 != null) {
                l1 = l1.next;
            }
            if (l2 != null) {
                l2 = l2.next;
            }
        }

        return retRef.next;
    }
}
