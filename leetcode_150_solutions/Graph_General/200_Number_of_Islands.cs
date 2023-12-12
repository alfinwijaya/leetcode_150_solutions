public static class _200_Number_of_Islands
{
    static int[][] direction = new int[][] { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };

    public static int NumIslands(char[][] grid)
    {
        int island = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    island++;
                    sink(i, j, grid);
                }
            }
        }
        return island;
    }

    public static void sink(int i, int j, char[][] grid)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == '0')
        {
            return;
        }

        grid[i][j] = '0';

        for (int k = 0; k < direction.Length; k++)
        {
            sink(i + direction[k][0], j + direction[k][1], grid);
        }
    }
}