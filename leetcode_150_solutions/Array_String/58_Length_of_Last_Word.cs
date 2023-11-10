public static class _58_Length_of_Last_Word
{
    public static int LengthOfLastWord(string s)
    {
        int answer = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                if (answer > 0)
                {
                    return answer;
                }
                continue;
            }
            else
            {
                answer++;
            }
        }

        return answer;
    }
}