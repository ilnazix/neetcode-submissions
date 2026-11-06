/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null) return null;
        
        var pointer = head;
        var oldToCopy = new Dictionary<Node, Node>();

        while(pointer != null){
            var copy = new Node(pointer.val);
            oldToCopy.Add(pointer, copy);

            pointer = pointer.next;
        }

        pointer = head;
        while(pointer != null)
        {
            var copy = oldToCopy.GetValueOrDefault(pointer);

            if(pointer.next != null){
                copy.next = oldToCopy.GetValueOrDefault(pointer.next);
            }

            if(pointer.random != null){
                copy.random = oldToCopy.GetValueOrDefault(pointer.random);
            }

            pointer = pointer.next;
        }

        return oldToCopy.GetValueOrDefault(head);
    }
}
