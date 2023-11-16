public static class _226_Invert_Binary_Tree
{
    public static TreeNode InvertTree(TreeNode root)
    {
        if (root == null || (root.left == null && root.right == null))
        {
            return root;
        }

        if (root.left != null || root.right != null)
        {
            TreeNode temp = root.right;
            root.right = root.left;
            root.left = temp;
        }

        InvertTree(root.left);
        InvertTree(root.right);

        return root;
    }
}
