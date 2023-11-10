public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

public static class _141_Linked_List_Cycle
{
    public static bool HasCycle(ListNode head)
    {
        ListNode tortoise = head;
        ListNode rabbit = head;

        while (tortoise != null && rabbit != null && rabbit.next != null)
        {
            tortoise = tortoise.next!;
            rabbit = rabbit.next.next!;
            if (tortoise == rabbit)
            {
                return true;
            }
        }
        return false;
    }
}
