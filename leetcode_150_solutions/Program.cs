using System.Text;

while (true)
{
    Console.Clear();
    Console.Write("input number: ");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            int[] arr = new int[] { -3, 4, 3, 90 };
            int k = 9;
            var resArr = _1_Two_Sum.TwoSum(arr, 0);

            resArr.ToList().ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
            break;

        case "2":
            var ll4 = new ListNode(2);
            ll4.next = new ListNode(4);
            ll4.next.next = new ListNode(3);

            var ll5 = new ListNode(5);
            ll5.next = new ListNode(6);
            ll5.next.next = new ListNode(4);

            var llSum = _2_Add_Two_Numbers.AddTwoNumbers(ll4, ll5);
            while (llSum != null)
            {
                Console.Write(llSum.val + " ");
                llSum = llSum.next;
            }

            Console.WriteLine();

            ll4 = new ListNode(9);
            ll4.next = new ListNode(9);
            ll4.next.next = new ListNode(9);
            ll4.next.next.next = new ListNode(9);
            ll4.next.next.next.next = new ListNode(9);
            ll4.next.next.next.next.next = new ListNode(9);
            ll4.next.next.next.next.next.next = new ListNode(9);

            ll5 = new ListNode(9);
            ll5.next = new ListNode(9);
            ll5.next.next = new ListNode(9);
            ll5.next.next.next = new ListNode(9);

            llSum = _2_Add_Two_Numbers.AddTwoNumbers(ll4, ll5);
            while (llSum != null)
            {
                Console.Write(llSum.val + " ");
                llSum = llSum.next;
            }

            Console.WriteLine();

            break;

        case "9":
            var palindrome = _9_Palindrome_Number.IsPalindrome(121);

            Console.WriteLine(palindrome);
            break;

        case "11":
            arr = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int result = _11_Container_With_Most_Water.MaxArea(arr);

            Console.WriteLine(result);
            Console.WriteLine();

            arr = new int[] { 1, 1 };
            result = _11_Container_With_Most_Water.MaxArea(arr);

            Console.WriteLine(result);
            Console.WriteLine();

            break;

        case "13":
            var strings = "MCMXCIV";
            result = _13_Roman_to_Integer.RomanToInt(strings);

            Console.WriteLine(result); 
            Console.WriteLine();
            break;

        case "14":
            string[] strArr = new string[] { "flower", "flow", "flight" };
            string res = _14_Longest_Common_Prefix.LongestCommonPrefix(strArr);

            Console.WriteLine(res);
            Console.WriteLine();
            break;

        case "15":
            arr = new int[] { -1, 0, 1, 2, -1, -4 };
            var listRes = _15_3Sum.ThreeSum(arr);

            foreach (var sublist in listRes)
            {
                foreach (var element in sublist)
                {
                    Console.Write($"{element} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            break;

        case "21":
            var ll2 = new ListNode2(5);

            var ll3 = new ListNode2(1);
            ll3.next = new ListNode2(2);
            ll3.next.next = new ListNode2(4);
            var merged = _21_Merge_Two_Sorted_Lists.MergeTwoLists(ll2, ll3);

            while (merged != null)
            {
                Console.Write(merged.val + " ");
                merged = merged.next;
            }

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

        case "35":
            nums = new int[] { 1, 3 };
            result = _35_Search_Insert_Position.SearchInsert(nums, 2);
            Console.WriteLine(result);
            Console.WriteLine();

            nums = new int[] { 1, 3, 5, 6 };
            result = _35_Search_Insert_Position.SearchInsert(nums, 5);
            Console.WriteLine(result);
            Console.WriteLine();

            nums = new int[] { 1, 3, 5, 6 };
            result = _35_Search_Insert_Position.SearchInsert(nums, 2);
            Console.WriteLine(result);
            Console.WriteLine();

            nums = new int[] { 1, 3, 5, 6 };
            result = _35_Search_Insert_Position.SearchInsert(nums, 7);
            Console.WriteLine(result);
            Console.WriteLine();
            break;

        case "36":
            char[][] matrix = new char[][] {
                new char[] {'8', '3', '.', '.', '7', '.', '.', '.', '.'},
                new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            var sudoku = _36_Valid_Sudoku.IsValidSudoku(matrix);
            Console.WriteLine(sudoku);
            Console.WriteLine();

            matrix = new char[][] {
                new char[] { '.', '.', '.', '.', '5', '.', '.', '1', '.' },
                new char[] { '.', '4', '.', '3', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '3', '.', '.', '1' },
                new char[] { '8', '.', '.', '.', '.', '.', '.', '2', '.' },
                new char[] { '.', '.', '2', '.', '7', '.', '.', '.', '.' },
                new char[] { '.', '1', '5', '.', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '.', '.', '.', '2', '.', '.', '.' },
                new char[] { '.', '2', '.', '9', '.', '.', '.', '.', '.' },
                new char[] { '.', '.', '4', '.', '.', '.', '.', '.', '.' }
            };

            sudoku = _36_Valid_Sudoku.IsValidSudoku(matrix);
            Console.WriteLine(sudoku);
            break;

        case "49":
            strArr = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            var nestedList = _49_Group_Anagrams.GroupAnagrams(strArr);

            for (int i = 0; i < nestedList.Count; i++)
            {
                foreach (var element in nestedList[i])
                    Console.Write($"{element} ");

                if (i != nestedList.Count - 1)
                    Console.Write(", ");
            }

            Console.WriteLine();
            break;

        case "55":
            nums = new int[] { 3, 2, 1, 0, 4 };
            var boolRes = _55_Jump_Game.CanJump(nums);
            Console.WriteLine(boolRes);
            Console.WriteLine();

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

        case "66":
            nums = new int[] { 1, 2, 3 };
            resArr = _66_Plus_One.PlusOne(nums);

            resArr.ToList().ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();

            nums = new int[] { 4, 3, 2, 1 };
            resArr = _66_Plus_One.PlusOne(nums);

            resArr.ToList().ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();

            nums = new int[] { 9 };
            resArr = _66_Plus_One.PlusOne(nums);

            resArr.ToList().ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
            break;

        case "70":
            result = _70_Climbing_Stairs.ClimbStairs(5);

            Console.WriteLine(result);
            Console.WriteLine();

            result = _70_Climbing_Stairs.ClimbStairs(45);

            Console.WriteLine(result);
            Console.WriteLine();

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

        case "100":
            TreeNode tree = new TreeNode(
                1,
                new TreeNode(2),
                new TreeNode(3)
            );

            TreeNode tree2 = new TreeNode(
                1,
                new TreeNode(2),
                new TreeNode(3)
            );

            var same = _100_Same_Tree.IsSameTree(tree, tree2);
            Console.WriteLine(same);
            Console.WriteLine();

            break;

        case "101":
            tree = new TreeNode(
                1,
                new TreeNode(2),
                new TreeNode(3)
            );

            var mirrored = _101_Symmetric_Tree.IsSymmetric(tree);
            Console.WriteLine(mirrored);
            Console.WriteLine();

            break;

        case "104":
            tree = new TreeNode(
                3,
                new TreeNode(9),
                new TreeNode(20,
                    new TreeNode(15),
                    new TreeNode(7)
                )
            );

            result = _104_Maximum_Depth_of_Binary_Tree.MaxDepth(tree);
            Console.WriteLine();
            Console.WriteLine(result);

            break;

        case "108":
            arr = new int[] { -10, -3, 0, 5, 9 };

            var bst = _108_Convert_Sorted_Array_to_Binary_Search_Tree.SortedArrayToBST(arr);
            Console.WriteLine(bst);
            Console.WriteLine();

            break;

        case "112":
            tree = new TreeNode(
                1,
                new TreeNode(2)
            );
            int target = 1;

            var has = _112_Path_Sum.HasPathSum(tree, target);
            Console.WriteLine(has);
            Console.WriteLine();

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

        case "122":
            nums = new int[] { 7, 1, 5, 3, 6, 4 };
            result = _122_Best_Time_to_Buy_and_Sell_Stock_II.MaxProfit(nums);

            Console.WriteLine(result);
            Console.WriteLine();

            nums = new int[] { 1, 2, 3, 4, 5 };
            result = _122_Best_Time_to_Buy_and_Sell_Stock_II.MaxProfit(nums);

            Console.WriteLine(result);
            Console.WriteLine();
            break;

        case "125":
            strings = "A man, a plan, a canal: Panama";
            boolRes = _125_Valid_Palindrome.IsPalindrome(strings);

            Console.WriteLine(boolRes);
            Console.WriteLine();

            strings = " ";
            boolRes = _125_Valid_Palindrome.IsPalindrome(strings);

            Console.WriteLine(boolRes);
            Console.WriteLine();

            strings = "0P";
            boolRes = _125_Valid_Palindrome.IsPalindrome(strings);

            Console.WriteLine(boolRes);
            Console.WriteLine();
            break;

        case "129":
            tree = new TreeNode(
                       0,
                       new TreeNode(1)
                   );

            result = _129_Sum_Root_to_Leaf_Numbers.SumNumbers(tree);
            Console.WriteLine(result);
            Console.WriteLine();

            tree = new TreeNode(
                    1,
                    new TreeNode(2),
                    new TreeNode(3)
                );

            result = _129_Sum_Root_to_Leaf_Numbers.SumNumbers(tree);
            Console.WriteLine(result);
            Console.WriteLine();
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

        case "151":
            strings = "the sky is blue";
            res = _151_Reverse_Words_in_a_String.ReverseWords(strings);

            Console.WriteLine(res);
            Console.WriteLine();

            strings = "  hello world  ";
            res = _151_Reverse_Words_in_a_String.ReverseWords(strings);

            Console.WriteLine(res);
            Console.WriteLine();

            strings = "a good   example";
            res = _151_Reverse_Words_in_a_String.ReverseWords(strings);

            Console.WriteLine(res);
            Console.WriteLine();
            break;
            
        case "167":
            nums = new int[] { 2, 7, 11, 15 };
            target = 9;
            resArr = _167_Two_Sum_II_Input_Array_Is_Sorted.TwoSum(nums, target);

            resArr.ToList().ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();

            nums = new int[] { 2, 3, 4 };
            target = 6;
            resArr = _167_Two_Sum_II_Input_Array_Is_Sorted.TwoSum(nums, target);

            resArr.ToList().ForEach(x => Console.Write($"{x} "));
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

        case "189":
            nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            _189_Rotate_Array.Rotate(nums, 3);

            nums.ToList().ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
            break;

        case "202":
            k = 19;
            boolRes = _202_Happy_Number.IsHappy(k);

            Console.WriteLine(boolRes);
            Console.WriteLine();

            k = 2;
            boolRes = _202_Happy_Number.IsHappy(k);

            Console.WriteLine(boolRes);
            Console.WriteLine();
            break;

        case "205":
            var subSeq = "badc";
            strings = "baba";
            boolRes = _205_Isomorphic_Strings.IsIsomorphic(subSeq, strings);

            Console.WriteLine(boolRes);
            Console.WriteLine();

            subSeq = "paper";
            strings = "title";
            boolRes = _205_Isomorphic_Strings.IsIsomorphic(subSeq, strings);

            Console.WriteLine(boolRes);
            Console.WriteLine();
            break;

        case "219":
            arr = new int[] { 1, 0, 1, 1 };
            k = 1;
            boolRes = _219_Contains_Duplicate_II.ContainsNearbyDuplicate(arr, 0);

            Console.WriteLine(boolRes);
            Console.WriteLine();
            break;

        case "222":
            tree = new TreeNode(
                1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)),
                new TreeNode(3,
                    new TreeNode(6))
            );

            result = _222_Count_Complete_Tree_Nodes.CountNodes(tree);
            Console.WriteLine(result);
            Console.WriteLine();
            break;

        case "226":
            tree = new TreeNode(
                1,
                new TreeNode(2),
                new TreeNode(3)
            );

            var inverted = _226_Invert_Binary_Tree.InvertTree(tree);
            Console.WriteLine(inverted);
            Console.WriteLine();

            tree = new TreeNode(
                4,
                new TreeNode(2,
                    new TreeNode(1),
                    new TreeNode(3)
                ),
                new TreeNode(7,
                    new TreeNode(6),
                    new TreeNode(9)
                )
            );

            inverted = _226_Invert_Binary_Tree.InvertTree(tree);
            Console.WriteLine(inverted);
            Console.WriteLine();
            break;

        case "228":
            arr = new int[] { 0, 2, 3, 4, 6, 8, 9 };
            var resList = _228_Summary_Ranges.SummaryRanges(arr);

            resList.ToList().ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();

            arr = new int[] { 0, 1, 2, 4, 5, 7 };
            resList = _228_Summary_Ranges.SummaryRanges(arr);

            resList.ToList().ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();

            arr = new int[] { 0, 1, 2 };
            resList = _228_Summary_Ranges.SummaryRanges(arr);

            resList.ToList().ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
            break;

        case "238":
            arr = new int[] {1, 2, 3, 4 };
            resArr = _238_Product_of_Array_Except_Self.ProductExceptSelf(arr);

            resArr.ToList().ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
            break;

        case "290":
            subSeq = "abba";
            strings = "dog cat cat dog";
            boolRes = _290_Word_Pattern.WordPattern(subSeq, strings);

            Console.WriteLine(boolRes);
            Console.WriteLine();

            subSeq = "abba";
            strings = "dog cat cat fish";
            boolRes = _290_Word_Pattern.WordPattern(subSeq, strings);

            Console.WriteLine(boolRes);
            Console.WriteLine();
            break;
        
        case "383":
            subSeq = "aa";
            strings = "aab";
            boolRes = _383_Ransom_Note.CanConstruct(subSeq, strings);

            Console.WriteLine(boolRes);
            Console.WriteLine();

            subSeq = "aa";
            strings = "ab";
            boolRes = _383_Ransom_Note.CanConstruct(subSeq, strings);

            Console.WriteLine(boolRes);
            break;

        case "392":
            subSeq = "abc";
            strings = "ahbgdc";
            boolRes = _392_Is_Subsequence.IsSubsequence(subSeq, strings);

            Console.WriteLine(boolRes);
            Console.WriteLine();

            subSeq = "b";
            strings = "abc";
            boolRes = _392_Is_Subsequence.IsSubsequence(subSeq, strings);

            Console.WriteLine(boolRes);
            Console.WriteLine();
            break;

        case "530":
            tree = new TreeNode(
                    4,
                    new TreeNode(2,
                        new TreeNode(1),
                        new TreeNode(3)),
                    new TreeNode(6)
                    );

            result = _530_Minimum_Absolute_Difference_in_BST.GetMinimumDifference(tree);
            Console.WriteLine(result);
            Console.WriteLine();
            break;

        case "637":
            tree = new TreeNode(
                3,
                new TreeNode(9,
                    new TreeNode(10)),
                new TreeNode(20,
                    new TreeNode(15),
                    new TreeNode(7))
            );

            var doubleResArr = _637_Average_of_Levels_in_Binary_Tree.AverageOfLevels(tree);
            doubleResArr.ToList().ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();
            break;

        default:
            break;
    }

    Console.ReadKey();
}