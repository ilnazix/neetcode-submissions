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
        var (firstPart, secondPart) = Split(head);
        var reversedSecondPart = Reverse(secondPart);

        head =  Merge(firstPart, reversedSecondPart);
    }

    private (ListNode first, ListNode second) Split(ListNode head){
        var slow = head;
        var fast = head?.next;

        while(fast != null){
            slow = slow.next;
            fast = fast.next?.next;
        }

        var first = head;
        var second = slow.next;

        slow.next = null;

        return (first, second);
    }

    private ListNode Reverse(ListNode head){
        ListNode first = null;
        ListNode second = head;

        while(second != null){
            var next = second.next;

            second.next = first;
            first = second;
            second = next;
        }

        return first;
    }

    private ListNode Merge(ListNode first, ListNode second){
        var dummy = new ListNode();
        var result = dummy;

        while(first != null && second != null){
            var firstNext = first.next;
            var secondNext = second.next;

            result.next = first;
            result.next.next = second;

            result = result.next.next;
            
            first = firstNext;
            second = secondNext;
        }

        result.next = first ?? second;

        return dummy.next;
    }
}
