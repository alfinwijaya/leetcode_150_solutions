public static class _9_Palindrome_Number
{
    public static  bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }

        int y = x;
        int rotated = 0;
        while (y > 0)
        {
            rotated = (rotated * 10) + (y % 10);
            y = y / 10;
        }

        return rotated == x;
    }
}
