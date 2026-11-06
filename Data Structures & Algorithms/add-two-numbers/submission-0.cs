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
        ListNode dummy = new ListNode();
        ListNode resultTail = dummy;
        int ost = 0;

        while(!(l1 == null && l2 == null)){
            int first = l1 == null ? 0 : l1.val;
            int second = l2 == null ? 0 : l2.val;
            
            int sum =  first + second + ost;
            
            ost = sum / 10;
            resultTail.next = new ListNode(sum % 10);

            l1 = l1?.next;
            l2 = l2?.next;
            resultTail = resultTail.next;
        }

        if(ost != 0){
            resultTail.next = new ListNode(ost);
        }

        return dummy.next;
    }
}
