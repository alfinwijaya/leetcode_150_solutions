public static class _383_Ransom_Note
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> ransomDict = new();
        Dictionary<char, int> magazineDict = new();

        foreach (var c in magazine)
        {
            if (magazineDict.ContainsKey(c))
            {
                magazineDict[c] += 1;
            }
            else
            {
                magazineDict[c] = 1;
            }
        }

        # region 2 loop
        foreach (var c in ransomNote)
        {
            if (ransomDict.ContainsKey(c))
            {
                ransomDict[c] += 1;
            }
            else
            {
                ransomDict[c] = 1;
            }
        }

        foreach(var key in ransomDict.Keys)
        {
            ransomDict.TryGetValue(key, out int ran);
            magazineDict.TryGetValue(key, out int mag);

            if (ran > mag || mag == 0)
            {
                return false;
            }
        }
        #endregion

        #region 1 loop
        /*
        foreach (var c in ransomNote)
        {
            if (magazineDict.ContainsKey(c))
            {
                magazineDict[c] -= 1;
            }
            else
            {
                return false;
            }

            magazineDict.TryGetValue(c, out int mag);
            if (mag < 0)
            {
                return false;
            }

        }
        */
        #endregion

        return true;

    }
}
