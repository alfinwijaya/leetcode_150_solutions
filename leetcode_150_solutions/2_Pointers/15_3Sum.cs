public static class _15_3Sum
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        List<List<int>> list = new();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int current = nums[i];
            int p1 = i + 1;
            int p2 = nums.Length - 1;

            while (p1 < p2)
            {
                int sum = current + nums[p1] + nums[p2];
                if (sum == 0)
                {
                    List<int> add = new() { nums[i], nums[p1], nums[p2] };
                    list.Add(add);

                    p1++;
                    p2--;

                    while (p1 < p2 && nums[p1] == nums[p1 - 1])
                        p1++;
                    while (p1 < p2 && nums[p2] == nums[p2 + 1])
                        p2--;
                }
                else if (sum > 0)
                {
                    p2--;
                }
                else
                {
                    p1++;
                }
            }
        }

        return list.Select(list => list as IList<int>).ToList();
    }
}
