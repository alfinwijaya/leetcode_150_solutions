public static class _66_Plus_One
{
    public static int[] PlusOne(int[] digits)
    {

        if (digits[digits.Length - 1] != 9)
        {
            digits[digits.Length - 1] += 1;
            return digits;
        }

        List<int> result = new();
        bool end = false;

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9 && !end)
            {
                result.Add(0);
            }
            else if (digits[i] == 9 && digits[i + 1] == 0 && !end)
            {
                result.Add(0);
            }
            else
            {
                if (!end)
                {
                    result.Add(digits[i] + 1);
                    end = true;
                }
                else
                    result.Add(digits[i]);
            }

            if (i == 0 && result.Last() == 0)
            {
                result.Add(1);
            }
        }

        result.Reverse();
        return result.ToArray();
    }
}
