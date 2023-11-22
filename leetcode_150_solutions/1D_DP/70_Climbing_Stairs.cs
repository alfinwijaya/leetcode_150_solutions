public static class _70_Climbing_Stairs
{
    public static int ClimbStairs(int n)
    {
        int[] arr = new int[45];
        arr[0] = 1; arr[1] = 2;

        for (int i = 2; i < n; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
        }
        return arr[n - 1];
    }
}
