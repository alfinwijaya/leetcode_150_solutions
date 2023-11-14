public class ListNode2
{
    public int val;
    public ListNode2? next;
    public ListNode2(int val = 0, ListNode2? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public static class _21_Merge_Two_Sorted_Lists
{
    public static ListNode2 MergeTwoLists(ListNode2 list1, ListNode2 list2)
    {
        ListNode2 head = new();
        var current = head;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val) 
            { 
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        if (list1 != null) { current.next = list1; }
        else if (list2 != null) { current.next = list2; }

        return head.next;
    }
}

