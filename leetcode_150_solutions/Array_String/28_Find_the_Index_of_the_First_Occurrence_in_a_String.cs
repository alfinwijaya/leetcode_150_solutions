public static class _28_Find_the_Index_of_the_First_Occurrence_in_a_String
{
    public static int StrStr(string haystack, string needle)
    {
        int len = needle.Length;

        int i = 0;
        while (i + len - 1 < haystack.Length)
        {
            if (needle == haystack[i..(i + len)])
            {
                return i;
            }
            i++;
        }
        return -1;
    }
}

