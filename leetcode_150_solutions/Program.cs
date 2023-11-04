while (true)
{
    Console.Clear();
    Console.Write("input number: ");
    var input = Console.ReadLine();

    switch (input)
    {
        case "26":
            var nums = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int result = _26_Remove_Duplicates_from_Sorted_Array.RemoveDuplicates(nums);

            Console.WriteLine(result);
            nums.ToList().ForEach(x => Console.Write($"{x} "));

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

        default:
            break;
    }

    Console.ReadKey();
}