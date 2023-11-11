public static class _242_Valid_Anagram
{
    public static bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> sDict = new();
        Dictionary<char, int> tDict = new();

        foreach (var c in s)
        {
            if (sDict.ContainsKey(c))
            {
                sDict[c] += 1;
            } 
            else
            {
                sDict[c] = 1;
            }
        }

        foreach(var c in t)
        {
            if (tDict.ContainsKey(c))
            {
                tDict[c] += 1;
            }
            else
            {
                tDict[c] = 1;
            }
        }

        if (sDict.Count != tDict.Count) return false;

        foreach(var key in sDict.Keys)
        {
            if (!tDict.ContainsKey(key) || sDict[key] != tDict[key])
            {
                return false;
            }
        }
        return true;
    }
}
