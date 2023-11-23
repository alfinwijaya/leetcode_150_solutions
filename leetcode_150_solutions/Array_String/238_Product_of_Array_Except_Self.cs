public static class _238_Product_of_Array_Except_Self
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];

        int curr = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = curr;
            curr *= nums[i];
        }

        curr = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            result[i] = result[i] * curr;
            curr *= nums[i];
        }

        return result;
    }
}

