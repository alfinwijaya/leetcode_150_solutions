public static class _219_Contains_Duplicate_II
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> numsDict = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (numsDict.ContainsKey(nums[i]))
            {
                int cek = Math.Abs(numsDict[nums[i]] - i);
                if (cek <= k)
                {
                    return true;
                }
            }
            numsDict[nums[i]] = i;
        }
        return false;
    }
}
