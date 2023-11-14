public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public static class _104_Maximum_Depth_of_Binary_Tree
{
    public static int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;

        Console.Write(root.val + " ");
        int left = MaxDepth(root.left) + 1;
        int right = MaxDepth(root.right) + 1;

        return Math.Max(left, right);
    }
}
