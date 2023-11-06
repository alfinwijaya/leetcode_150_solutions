public static class _169_Majority_Element
{
    public static int MajorityElement(int[] nums)
    {   
        for (int i = 0; i < nums.Length; i++) 
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    int temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                }
            }
        }

        // Array.Sort(nums); If allow to use built in class

        return nums[nums.Length / 2]; // the center element is always the majority element because it appears more than [n / 2] 
    }
}