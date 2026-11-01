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
        if(list1 == null) return list2;
        if(list2 == null) return list1;
        
        ListNode head = null;

        if(list1.val < list2.val){
            head = list1;
            list1 = list1.next;
        } 
        else{
            head = list2;
            list2 = list2.next;
        }

        var prevMin = head;

        while(list1 != null && list2 != null){
            if(list1.val < list2.val){
                prevMin.next = list1;
                list1 = list1.next;
            }
            else{
                prevMin.next = list2;
                list2 = list2.next;
            }

            prevMin = prevMin.next;
        }

        prevMin.next = list1 != null ? list1 : list2;

        return head;
    }
}