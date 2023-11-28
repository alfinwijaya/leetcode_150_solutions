public static class _11_Container_With_Most_Water
{
    public static int MaxArea(int[] height)
    {
        int p1 = 0;
        int p2 = height.Length - 1;
        int max = 0;

        while (p1 < p2)
        {
            int area = Math.Min(height[p1], height[p2]) * (p2 - p1);
            if (area > max)
            {
                max = area;
            }
            else if (height[p2] > height[p1])
            {
                p1++;
            }
            else
            {
                p2--;
            }
        }
        return max;
    }
}