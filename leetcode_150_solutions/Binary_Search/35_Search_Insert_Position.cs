public static  class _35_Search_Insert_Position
{
    public static int SearchInsert(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;

        while (left < right)
        {
            int middle = left + ((right - left) / 2);
            if (nums[middle] == target)
            {
                return middle;
            }
            else if (nums[middle] > target)
            {
                right = middle - 1;
            }
            else if (nums[middle] < target)
            {
                left = middle + 1;
            }
        }

        if (nums[left] == target)
        {
            return left;
        }
        else if (nums[left] < target)
        {
            return left + 1;
        }
        return left;
    }
}
