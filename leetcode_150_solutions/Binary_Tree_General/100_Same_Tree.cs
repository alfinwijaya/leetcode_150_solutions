
public static class _100_Same_Tree
{
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;
        if ((p == null || q == null) || (p.val != q.val)) return false;

        bool checkleft = IsSameTree(p.left, q.left);
        bool checkRight = IsSameTree(p.right, q.right);

        return checkleft && checkRight;
    }
}
