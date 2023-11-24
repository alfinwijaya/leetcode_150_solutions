using System.Text;

public static class _151_Reverse_Words_in_a_String
{
    public static string ReverseWords(string s)
    {
        List<string> words = new();
        StringBuilder sb = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                sb.Append(s[i].ToString());
            }
            
            if ((s[i] == ' ' || i == s.Length - 1) && sb.Length > 0)
            {
                words.Add(sb.ToString());
                sb = new();
            }
        }

        words.Reverse();
        return string.Join(" ", words);
    }
}