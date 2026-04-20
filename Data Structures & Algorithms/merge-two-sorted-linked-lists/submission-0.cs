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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode ret = new ListNode();
        ListNode refhead = ret;


        while (list1 != null && list2 != null) {
            if (list1.val <= list2.val) {
                refhead.next = list1;
                list1 = list1.next;
            }
            else {
                refhead.next = list2;
                list2 = list2.next;
            }
            refhead = refhead.next;
        }

        if (list1 != null) {
            refhead.next = list1;
        }
        else {
            refhead.next = list2;
        }

        return ret.next;
    }
}