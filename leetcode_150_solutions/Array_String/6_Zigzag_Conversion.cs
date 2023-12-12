using System.Text;

public static class _6_Zigzag_Conversion
{
    public static string Convert(string s, int numRows)
    {
        if (numRows == 1) 
            return s;

        List<List<string>> zigZag = new();
        for (int i = 0; i < numRows; i++)
        {
            zigZag.Add(new List<string>());
        }

        var currentPos = 0;
        var zag = false;
        var zagCount = numRows - 1;
        var correctedPos = 0;

        for (int i = 0; i < s.Length; i++)
        {
            currentPos = i > numRows ? (i-correctedPos) % numRows : i % numRows;
            if (i != 0 && currentPos == 0)
                zag = true;

            if (zag)
            {
                zagCount--;
                zigZag[zagCount].Add(s[i].ToString());

                if (zagCount == 0)
                {
                    zag = false;
                    zagCount = numRows - 1;
                }
                else
                {
                    correctedPos++;
                }
            }
            else
                zigZag[currentPos].Add(s[i].ToString());
        }

        var sb = new StringBuilder();

        foreach(var str in zigZag) 
        {
            sb.Append(string.Join("", str));
        }

        return sb.ToString();
    }
}
