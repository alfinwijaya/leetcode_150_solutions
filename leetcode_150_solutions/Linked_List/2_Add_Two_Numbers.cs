public static class _2_Add_Two_Numbers
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new(0);
        var current = result;

        int sisaJumlah = 0;
        int sum = 0;
        string temp = string.Empty;
        while (l1 != null && l2 != null) 
        {
            sum = l1.val + l2.val + sisaJumlah;
            if (sum >= 10)
            {
                temp = sum.ToString();
                sum = Convert.ToInt32(temp[1].ToString());
                sisaJumlah = Convert.ToInt32(temp[0].ToString());
            }
            else
            {
                sisaJumlah = 0;
            }

            l1 = l1.next; l2 = l2.next;

            current.next = new ListNode(sum);
            current = current.next;
        }

        if (l1 != null)
        {
            while (l1 != null)
            {
                sum = l1.val + sisaJumlah;
                if (sum >= 10)
                {
                    temp = sum.ToString();
                    sum = Convert.ToInt32(temp[1].ToString());
                    sisaJumlah = Convert.ToInt32(temp[0].ToString());
                }
                else
                {
                    sisaJumlah = 0;
                }

                l1 = l1.next;

                current.next = new ListNode(sum);
                current = current.next;
            }
        }
        else if (l2 != null)
        {
            while (l2 != null) 
            {
                sum = l2.val + sisaJumlah;
                if (sum >= 10)
                {
                    temp = sum.ToString();
                    sum = Convert.ToInt32(temp[1].ToString());
                    sisaJumlah = Convert.ToInt32(temp[0].ToString());
                }
                else
                {
                    sisaJumlah = 0;
                }

                l2 = l2.next;

                current.next = new ListNode(sum);
                current = current.next;
            }
        }

        if (sisaJumlah > 0) 
        {
            current.next = new ListNode(sisaJumlah);
        }

        return result.next;
    }
}
