public static class _13_Roman_to_Integer
{
    public static int RomanToInt(string s)
    {
        Dictionary<char, int> romanValue = new() { 
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int integerValue = 0;
        int i = s.Length - 1;
        while (i >= 0)
        {
            if (i >= 1)
            {
                if (((s[i] == 'V' || s[i] == 'X') && s[i - 1] == 'I') ||
                    ((s[i] == 'L' || s[i] == 'C') && s[i - 1] == 'X') ||
                    ((s[i] == 'D' || s[i] == 'M') && s[i - 1] == 'C'))
                {
                    integerValue += romanValue[s[i]] - romanValue[s[i - 1]];
                    i -= 2;
                }
                else
                {
                    integerValue += romanValue[s[i]];
                    i--;
                }
            }
            else
            {
                integerValue += romanValue[s[i]];
                i--;
            }
        }

        return integerValue;
    }
}
