using System.Diagnostics.CodeAnalysis;

public static class _27_RemoveElement
{
    public static int RemoveElement(int[] nums, int val)
    {
        int first = 0; // point at the first index
        int last = nums.Length - 1; // point at the last index

        if (nums.Length == 0) return 0;
        if (nums.Length == 1) 
        {
            if (nums[0] == val) return 0; 
            else return 1; 
        }

        while (first <= last) // if first met last it mean we already check all members of nums hence the loop is finished
        {
            if (nums[first] == val) // if the current number is val then we switch the position with member of last index
            {
                int temp = nums[last];
                nums[last] = nums[first];
                nums[first] = temp;
                last--; // decreasing the last value because the current value on last index is already equal to val so we don't need to check it anymore
            }
            else
            {
                first++; // if the current number is not val then we skip it by increasing first variable
            }
        }

        return first;
    }
}
