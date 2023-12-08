public static class _530_Minimum_Absolute_Difference_in_BST
{
    static List<int> tree = new();
    public static int GetMinimumDifference(TreeNode root, int valBefore = 0)
    {
        Traverse(root);
        int min = int.MaxValue;

        for (int i = 1; i < tree.Count; i++)
        {
            min = Math.Min(min, Math.Abs(tree[i] - tree[i - 1]));
        }

        return min;
    }

    public static void Traverse(TreeNode root)
    {
        if (root == null) return;

        Traverse(root.left);
        tree.Add(root.val);
        Traverse(root.right);
    }
}

