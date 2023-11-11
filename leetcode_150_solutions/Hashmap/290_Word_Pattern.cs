 public static class _290_Word_Pattern
{
    public static bool WordPattern(string pattern, string s)
    {
        Dictionary<string, string> sDict = new();
        string[] sArr = s.Split(" ");

        if (pattern.Length != sArr.Length) return false;

        int i = 0;
        foreach (var c in sArr)
        {
            if (sDict.ContainsKey(pattern[i].ToString()))
            {
                if (sDict[pattern[i].ToString()] != c)
                {
                    return false;
                }
            }
            else
            {
                if (sDict.ContainsValue(c))
                {
                    return false;
                }
                sDict[pattern[i].ToString()] = c;
            }
            i++;
        }
        return true;
    }
}

