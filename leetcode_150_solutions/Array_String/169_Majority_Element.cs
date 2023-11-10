public static class _169_Majority_Element
{
    public static int MajorityElement(int[] nums)
    {
        Dictionary<int, int> occurence = new();

        for (int i = 0; i < nums.Length; i++)
        {
            if (occurence.ContainsKey(nums[i]))
            {
                occurence[nums[i]] += 1;
            }
            else
            {
                occurence[nums[i]] = 1;
            }

            if (occurence[nums[i]] > nums.Length / 2)
            {
                return nums[i];
            }
        }

        return 0;
    }
}