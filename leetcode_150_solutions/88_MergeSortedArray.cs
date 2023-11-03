public static class _88_MergeSortedArray
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int hitung_1 = m - 1; // point to biggest non zero int number on nums1
        int hitung_2 = n - 1; // point to biggest non zero int number on nums2
        int ujung = m + n - 1; // point to the back of nums1 

        if (n == 0) return;

        while (hitung_1 >= 0) 
        {
            if (nums1[hitung_1] > nums2[hitung_2]) 
            {
                nums1[ujung] = nums1[hitung_1]; // push the number to the end of nums1 because it is the biggest
                hitung_1--; ujung--;
            }
            else
            {
                nums1[ujung] = nums2[hitung_2]; // push the number to the end of nums1 because it is the biggest
                hitung_2--; ujung--;
            }

            if (hitung_2 < 0) // if all of nums2 members have been evaluated
                return;
        }

        while (hitung_2 >= 0) // some member of nums2 haven't been evaluated yet because hitung_1 loop already terminated 
        {
            nums1[ujung] = nums2[hitung_2];
            hitung_2--; ujung--;
        }
    }
}