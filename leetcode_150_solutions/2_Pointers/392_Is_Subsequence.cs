public static class _392_Is_Subsequence
{
    public static bool IsSubsequence(string s, string t)
    {
        #region 2 Pointer
        /*
        int pointer_1 = 0;
        int pointer_2 = 0;

        while (pointer_1 < s.Length && pointer_2 < t.Length)
        {
            if (s[pointer_1] == t[pointer_2])
            {
                pointer_1++;
            }
            pointer_2++;
        }

        if (pointer_1 == s.Length)
        {
            return true;
        }
        return false;
        */
        #endregion

        #region Queue
        Queue<char> queue = new(s);

        if (queue.Count == 0)
        {
            return true;
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (t[i] == queue.Peek())
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                return true;
            }
        }
        
        return false;
        #endregion

    }
}
