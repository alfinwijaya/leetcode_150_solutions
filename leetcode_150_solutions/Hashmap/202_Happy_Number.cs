public static class _202_Happy_Number
{
    public static bool IsHappy(int n)
    {
        int result = 0;
        Dictionary<int, bool> map = new();
        string str = Convert.ToString(n);

        while (result != 1) 
        {
            result = 0;
            foreach (char c in str)
            {
                result += Convert.ToInt32(c.ToString()) * Convert.ToInt32(c.ToString());
            }

            if (map.ContainsKey(result))
            {
                return false;
            }
            else
            {
                map[result] = true;
            }
            str = Convert.ToString(result);
        }

        return true;
    }
}