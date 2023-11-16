public static class _101_Symmetric_Tree
{
    public static bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;

        return IsSymmetricHelper(root.left, root.right);
    }

    public static bool IsSymmetricHelper(TreeNode left, TreeNode right)
    {
        if (left == null && right == null) return true;
        if ((left == null || right == null) || (left.val != right.val)) return false;

        var leftMirrorRight = IsSymmetricHelper(left.left, right.right);
        var rightMirrorLeft = IsSymmetricHelper(left.right, right.left);

        return leftMirrorRight && rightMirrorLeft;
    }
}