public static class _26_Remove_Duplicates_from_Sorted_Array
{
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;
        else if (nums.Length == 1 || (nums.Length == 2 && nums[0] == nums[1])) return 1;

        int inc = 1;
        int max = nums[nums.Length - 1];

        while (nums[inc] != max)
        {
            if (nums[inc] == nums[inc - 1])
            {
                int secondInc = inc;
                while (nums[secondInc - 1] != max)
                {
                    int temp = nums[secondInc];
                    nums[secondInc] = nums[secondInc + 1];
                    nums[secondInc + 1] = temp;
                    secondInc++;
                }
            }
            else
            {
                inc++;
            }

        }

        return Array.IndexOf(nums, max) + 1;
    }
}

