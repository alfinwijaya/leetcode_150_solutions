public static class _189_Rotate_Array
{
    public static void Rotate(int[] nums, int k)
    {
        List<int> cmpr = new List<int>(nums); 

        for (int j = 0; j < nums.Length; j++)
        {
            int newpos = (j + k) % nums.Length;
            nums[newpos] = cmpr[j];
        }
    }

    /* 2nd Solution
    public static void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;

        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }

    public static void Reverse(int[] nums, int start, int end)
    {
        while (start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }
    }
    */
}
