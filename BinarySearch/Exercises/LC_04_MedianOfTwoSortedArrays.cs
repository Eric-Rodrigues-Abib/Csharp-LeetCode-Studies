namespace BinarySearch.Exercises
{
    // LeetCode 4: Median of Two Sorted Arrays
    // Link: https://leetcode.com/problems/median-of-two-sorted-arrays/description/
    // Difficulty: Hard
    // Tags: Binary Search

    public class LC_4_MedianofTwoSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] mergedArrays = MergeSort(nums1, nums2);
            int len = mergedArrays.Length;

            double median;
            if (len % 2 == 0)
            {
                median = (mergedArrays[len/2] + mergedArrays[len/2-1]) / 2.0;
                return median;
            } else
            {
                median = mergedArrays[len/2];
                return median;
            }
        }

        private static int[] MergeSort(int[] nums1, int[] nums2)
        {
            int n = nums1.Length;
            int m = nums2.Length;
            int i=0, j =0, k=0;

            int[] merged = new int[n + m];

            while (i < n && j < m)
            {
                if (nums1[i] <= nums2[j])
                {
                    merged[k++] = nums1[i++];
                } else
                {
                    merged[k++] = nums2[j++];
                }
            }

            while (i < n)
            {
                merged[k++] = nums1[i++];
            }
            while (j < m)
            {
                merged[k++] = nums2[j++];
            }
            
            return merged;
        }
    }
}