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
        var dummy2 = new ListNode(0, head);
        var dummy1 = new ListNode(0, dummy2);

        var slow = dummy1;
        var fast = dummy2;

        while(fast != null){
            slow = slow.next;
            fast = fast.next?.next;

            if(fast == slow) return true;
        }

        return false;
    }
}
