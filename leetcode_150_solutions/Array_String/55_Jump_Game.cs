public static class _55_Jump_Game
{
    public static bool CanJump(int[] nums)
    {
        // The Idea: Evaluate from back to front. If we can reach current target then reassigned target with the current pointer value
        // Initial target is last index and initial pointer is last index - 1
        // If we reach index 0 with at least 1 time of this rule applied then return true else false (true if at least nums[0] + 0 = target)

        int target = nums.Length - 1;
        int pointer = target - 1;

        if (pointer < 0)
        {
            return true;
        }

        while (pointer >= 0)
        {
            if (nums[pointer] + pointer >= target)
            {
                target = pointer;
                if (pointer == 0)
                {
                    return true;
                }
            }
            pointer--;
        }
        return false;
    }
}
