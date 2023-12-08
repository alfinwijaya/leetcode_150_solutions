using System.Security.AccessControl;

public static class _129_Sum_Root_to_Leaf_Numbers
{
    static List<string> list = new();
    public static int SumNumbers(TreeNode root, string curr = "")
    {
        Traverse(root);

        int sum = 0;
        for (int i = 0; i < list.Count; i++) 
        {
            sum += Convert.ToInt32(list[i]);
        }

        return sum;
    }

    public static void Traverse(TreeNode root, string curr = "")
    {
        if (root == null)
        {
            return;
        }
        else if (root.left == null && root.right == null) 
        {
            curr += root.val.ToString();
            list.Add(curr);
            return;
        }

        curr += root.val.ToString();
        Traverse(root.left, curr);
        Traverse(root.right, curr);

        return;
    }

}