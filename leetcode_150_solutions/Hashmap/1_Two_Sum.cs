public static class _1_Two_Sum
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numsDict = new();

        for (int i = 0; i < nums.Length; i++)
        {
            int sisa = target - nums[i];
            if (numsDict.ContainsKey(sisa))
            {
                return new int[] { numsDict[sisa], i };
            }
            else
            {
                numsDict[nums[i]] = i;
            }
        }
        return Array.Empty<int>();
    }

}
