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
        var first = (ListNode) null;
        var second = head;

        while(second != null){
            var tmp = second.next;

            second.next = first;

            first = second;
            second = tmp;
        }

        return first;
    }
}
