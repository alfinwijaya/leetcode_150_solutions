public static class _112_Path_Sum
{
    public static bool HasPathSum(TreeNode root, int targetSum)
    {
        if (root == null) return false;

        targetSum -= root.val;
        if (root.left == null && root.right == null && targetSum == 0)
            return true;

        bool checkLeft = HasPathSum(root.left, targetSum);
        bool checkRight = HasPathSum(root.right, targetSum);

        return checkLeft || checkRight;
    }
}
