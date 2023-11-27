public static class _167_Two_Sum_II_Input_Array_Is_Sorted
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        int p1 = 0;
        int p2 = numbers.Length - 1;

        while (p1 < p2)
        {
            if (numbers[p1] + numbers[p2] == target)
            {
                return new int[] { p1 + 1, p2 + 1 };
            }
            else if (numbers[p1] + numbers[p2] > target)
            {
                p2--;
            }
            else
            {
                p1++;
            }
        }
        return Array.Empty<int>();
    }
}
