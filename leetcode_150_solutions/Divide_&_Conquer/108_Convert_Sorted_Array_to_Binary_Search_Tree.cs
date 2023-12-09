public static class _108_Convert_Sorted_Array_to_Binary_Search_Tree
{
    public static TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length == 0)
        {
            return null;
        }

        int middle = nums.Length / 2;
        var root = new TreeNode(nums[middle]);

        root.left = SortedArrayToBST(nums[0..middle]);
        root.right = SortedArrayToBST(nums[(middle + 1)..nums.Length]);

        return root;
    }
}
