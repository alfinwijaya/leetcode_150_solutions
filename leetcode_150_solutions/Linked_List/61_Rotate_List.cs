public static class _61_Rotate_List
{
    public static ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || k == 0) return head;

        var current = head;
        int len = 0;
        while (current.next != null)
        {
            current = current.next;
            len++;
        }
        len += 1;
        current.next = head;

        int move = len - (k % len);
        while (move > 0) 
        {
            current = head;
            head = head.next;
            move--;
        }
        current.next = null;

        return head;
    }
}