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
    public static int MaxDepth(TreeNode root, int left = 1, int right = 1)
    {
        if (root == null) return 0;

        Console.Write(root.val + " ");

        if (root.left != null)
        {
            int l = MaxDepth(root.left);
            left += l;
        }

        if (root.right != null)
        {
            int r = MaxDepth(root.right);
            right += r;
        }

        return Math.Max(left, right);
    }
}
