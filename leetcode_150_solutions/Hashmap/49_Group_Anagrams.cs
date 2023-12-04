public static class _49_Group_Anagrams
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> checker = new();
        List<IList<string>> result = new();

        for (int i = 0; i < strs.Length; i++) 
        {
            var temp = new string(strs[i].OrderBy(x => x).ToArray());

            if (checker.ContainsKey(temp!))
            {
                checker[temp!].Add(strs[i]);
            }
            else
            {
                checker[temp!] = new() { strs[i] };
            }
        }

        foreach (var value in checker.Values) 
        {
            result.Add(value);
        }
        return result;
    }
}
