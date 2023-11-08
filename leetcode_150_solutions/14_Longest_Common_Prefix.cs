public static class _14_Longest_Common_Prefix
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";

        var comparer = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            int j = 0;

            if (strs[i].Length < comparer.Length)
            {
                comparer = comparer[..strs[i].Length];
            }

            while (comparer.Length > j)
            {
                if (strs[i][j].ToString() != comparer[j].ToString())
                {
                    comparer = comparer[..j];

                    if (comparer.Length == 0)
                    {
                        return string.Empty;
                    }
                }
                j++;
            }
        }

        return comparer;
    }
}