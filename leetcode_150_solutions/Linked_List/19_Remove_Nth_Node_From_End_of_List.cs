public static class _19_Remove_Nth_Node_From_End_of_List
{
    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode result = new ListNode(0);
        var current = result;
        var p1 = head;
        int len = 0;

        while (p1 != null) 
        {
            len++;
            p1 = p1.next;
        }

        int target = len - n;
        int i = 1;

        while (i <= target) 
        {
            current.next = new ListNode(head.val);
            head = head.next;
            current = current.next;
            i++;
        }

        if (head.next != null)
        {
            current.next = head.next;
        }

        return result.next;
    }
}
