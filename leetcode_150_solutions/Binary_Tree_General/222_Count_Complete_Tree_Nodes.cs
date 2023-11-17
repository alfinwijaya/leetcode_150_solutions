public static class _222_Count_Complete_Tree_Nodes
{
    public static int CountNodes(TreeNode root)
    {
        if (root == null) return 0;

        int count = 1;
        count += CountNodes(root.left);
        count += CountNodes(root.right);

        return count;
    }
}
