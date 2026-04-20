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
        ListNode nodeRef = new();
        ListNode res = nodeRef;

        while (list1 != null && list2 != null) {
            if (list1.val >= list2.val) {
                nodeRef.next = list2;
                list2 = list2.next;
            }
            else if (list2.val >= list1.val) {
                nodeRef.next = list1;
                list1 = list1.next;
            }
            nodeRef = nodeRef.next;
        }

        if (list1 == null) {
            nodeRef.next = list2;
        }
        else {
            nodeRef.next = list1;
        }

        return res.next;
    }
}