using System.Xml.Linq;

public static class _637_Average_of_Levels_in_Binary_Tree
{
    public static IList<double> AverageOfLevels(TreeNode root)
    {
        List<double> result = new();

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);
        queue.Enqueue(null);
        long sum = 0;
        int len = 0;

        // count the tree depth https://www.geeksforgeeks.org/find-the-maximum-depth-or-height-of-a-tree/
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node == null)
            {
                result.Add((double)sum / (double)len);
                sum = 0;
                len = 0;
            }

            if (node != null)
            {
                sum += node.val;
                len++;
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            else if (queue.Count != 0)
            {
                queue.Enqueue(null);
            }
        }

        return result;
    }
}
