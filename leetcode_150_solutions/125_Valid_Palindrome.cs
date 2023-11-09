public static class _125_Valid_Palindrome
{
    public static bool IsPalindrome(string s)
    {
        string preProcessedStr = new string(s.ToLower().Where(c => Char.IsLetter(c) || Char.IsDigit(c)).ToArray());

        var pointer_1 = 0;
        var pointer_2 = preProcessedStr.Length - 1;

        while(pointer_1 != pointer_2 && pointer_1 >=0 && pointer_2 >=0)
        {
            if (preProcessedStr[pointer_1].ToString() != preProcessedStr[pointer_2].ToString())
            {
                return false;
            }

            pointer_1++;
            pointer_2--;
        }

        return true;
    }
}
