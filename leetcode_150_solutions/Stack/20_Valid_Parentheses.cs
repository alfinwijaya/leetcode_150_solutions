public static class _20_Valid_Parentheses
{
    public static bool IsValid(string s)
    {
        Stack<string> list = new();
        Dictionary<string, string> dic = new() { { "(", ")" }, { "{", "}" }, { "[", "]" } };

        foreach(var c in s)
        {
            if (dic.ContainsKey(c.ToString()))
            {
                list.Push(c.ToString());
            }
            else
            {
                list.TryPeek(out string? peek);
                if (string.IsNullOrWhiteSpace(peek))
                {
                    return false;
                }
                else if (dic[peek] == c.ToString())
                {
                    list.Pop();
                }
                else 
                {
                    return false;
                }
            }
        }

        if (list.Count == 0)
        {
            return true;
        }
        return false;
    }
}
