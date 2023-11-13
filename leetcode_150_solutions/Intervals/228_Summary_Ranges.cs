using System.Numerics;
using System.Reflection;

public static class _228_Summary_Ranges
{
    public static IList<string> SummaryRanges(int[] nums)
    {
        List<string> result = new();

        for(int i = 0; i < nums.Length; i++)
        {
            int j = i;
            while (j + 1 < nums.Length && nums[j] + 1 == nums[j+1])
            {
                j++;
            }

            if (j > i)
            {
                result.Add($"{nums[i]}->{nums[j]}");
            }
            else
            {
                result.Add($"{nums[i]}");
            }

            i = j;
        }
        return result;
    }
}
