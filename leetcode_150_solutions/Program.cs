while (true)
{
    Console.Clear();
    Console.Write("input number: ");
    var input = Console.ReadLine();

    switch (input)
    {
        case "13":
            var strings = "MCMXCIV";
            int result = _13_Roman_to_Integer.RomanToInt(strings);

            Console.WriteLine(result); 
            Console.WriteLine();
            break;

        case "14":
            string[] strArr = new string[] { "flower", "flow", "flight" };
            string res = _14_Longest_Common_Prefix.LongestCommonPrefix(strArr);

            Console.WriteLine(res);
            Console.WriteLine();
            break;

        case "26":
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            result = _26_Remove_Duplicates_from_Sorted_Array.RemoveDuplicates(nums);

            Console.WriteLine(result);
            nums.ToList().ForEach(x => Console.Write($"{x} "));

            Console.WriteLine();
            break;

        case "28":
            var haystack = "missisissipi";
            var needle = "issi";
            result = _28_Find_the_Index_of_the_First_Occurrence_in_a_String.StrStr(haystack, needle);

            Console.WriteLine(result);
            Console.WriteLine();

            haystack = "pneumonoultramicroscopicsilicovolcanoconiosis";
            needle = "sis";
            result = _28_Find_the_Index_of_the_First_Occurrence_in_a_String.StrStr(haystack, needle);

            Console.WriteLine(result);
            Console.WriteLine();
            break;

        case "27":
            nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }; var val = 2;
            result = _27_RemoveElement.RemoveElement(nums, val);

            Console.WriteLine(result);
            nums.ToList().ForEach(x => Console.Write($"{x} "));

            Console.WriteLine();

            nums = new int[] { 3, 3 }; val = 3;
            result = _27_RemoveElement.RemoveElement(nums, val);

            Console.WriteLine(result);
            nums.ToList().ForEach(x => Console.Write($"{x} "));
            break;

        case "58":
            strings = "   fly me   to   the moon  ";
            result = _58_Length_of_Last_Word.LengthOfLastWord(strings);

            Console.WriteLine(result);
            Console.WriteLine();

            strings = "luffy is still joyboy";
            result = _58_Length_of_Last_Word.LengthOfLastWord(strings);

            Console.WriteLine(result);
            break;

        case "88":

            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 }; var m = 3; var nums2 = new int[] { 2, 5, 6 }; var n = 3;
            _88_MergeSortedArray.Merge(nums1, m, nums2, n);
            nums1.ToList().ForEach(x => Console.Write($"{x} "));

            Console.WriteLine();

            nums1 = new int[] { 1 }; m = 1; nums2 = new int[] { }; n = 0;
            _88_MergeSortedArray.Merge(nums1, m, nums2, n);
            nums1.ToList().ForEach(x => Console.Write($"{x} "));

            Console.WriteLine();

            nums1 = new int[] { 0 }; m = 0; nums2 = new int[] { 1 }; n = 1;
            _88_MergeSortedArray.Merge(nums1, m, nums2, n);
            nums1.ToList().ForEach(x => Console.Write($"{x} "));

            Console.WriteLine();

            nums1 = new int[] { 2, 0 }; m = 1; nums2 = new int[] { 1 }; n = 1;
            _88_MergeSortedArray.Merge(nums1, m, nums2, n);
            nums1.ToList().ForEach(x => Console.Write($"{x} "));
            break;

        case "121":
            nums = new int[] { 7, 1, 5, 3, 6, 4 }; 
            result = _121_Best_Time_to_Buy_and_Sell_Stock.MaxProfit(nums);

            Console.WriteLine(result);
            nums.ToList().ForEach(x => Console.Write($"{x} "));

            Console.WriteLine();

            nums = new int[] { 7, 6, 4, 3, 1 };
            result = _121_Best_Time_to_Buy_and_Sell_Stock.MaxProfit(nums);

            Console.WriteLine(result);
            nums.ToList().ForEach(x => Console.Write($"{x} "));
            break;

        case "141":
            var ll = new ListNode(3);
            ll.next = new ListNode(2);
            ll.next.next = new ListNode(0);
            ll.next.next.next = new ListNode(-4);
            ll.next.next.next.next = ll.next;
            var cycle = _141_Linked_List_Cycle.HasCycle(ll);

            Console.WriteLine(cycle);
            Console.WriteLine();

            ll = null;
            cycle = _141_Linked_List_Cycle.HasCycle(ll);

            Console.WriteLine(cycle);
            Console.WriteLine();

            break;

        case "169":
            nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            result = _169_Majority_Element.MajorityElement(nums);

            Console.WriteLine(result);

            Console.WriteLine();

            nums = new int[] { 4, 5, 4 };
            result = _169_Majority_Element.MajorityElement(nums);

            Console.WriteLine(result);
            break;

        default:
            break;
    }

    Console.ReadKey();
}