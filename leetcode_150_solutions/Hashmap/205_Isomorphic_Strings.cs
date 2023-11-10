public static class _205_Isomorphic_Strings
{
    public static bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, char> sDict = new();

        for(int i = 0; i < s.Length; i++)
        {
            if (sDict.ContainsKey(s[i]))
            {
                if (sDict[s[i]] != t[i])
                {
                    return false;
                }
            }
            else
            {
                if (sDict.ContainsValue(t[i]))
                {
                    return false;
                }
                sDict[s[i]] = t[i];
            }
        }

        return true;

    }
}
