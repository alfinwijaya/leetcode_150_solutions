public static class _54_Spiral_Matrix
{
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> result = new();
        int top = 0;
        int bottom = matrix.Length - 1;
        int left = 0;
        int right = matrix[0].Length - 1;
        int total_item = matrix.Length * matrix[0].Length;

        while (true)
        {
            // -------→
            // ↑-----→|
            // |↑---→||
            // ||←--↓||
            // |←----↓|
            // ←------↓

            // Right
            for (int i = left; i <= right ; i++) 
            { 
                result.Add(matrix[top][i]);
            }
            top++;

            if (result.Count == total_item) break;

            // Down
            for (int i = top; i <= bottom; i++)
            {
                result.Add(matrix[i][right]);
            }
            right--;

            if (result.Count == total_item) break;

            // Left
            for (int i = right; i >= left; i--)
            {
                result.Add(matrix[bottom][i]);
            }
            bottom--;

            if (result.Count == total_item) break;

            // Up
            for (int i = bottom; i >= top; i--)
            {
                result.Add(matrix[i][left]);
            }
            left++;

            if (result.Count == total_item) break;
        }

        return result;
    }
}