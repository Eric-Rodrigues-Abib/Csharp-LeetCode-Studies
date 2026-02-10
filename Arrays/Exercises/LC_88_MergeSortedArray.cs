namespace Arrays.Exercises
{
    // LeetCode 88: Merge Sorted Array
    // Link: https://leetcode.com/problems/merge-sorted-array/
    // Difficulty: Easy
    // Tags: Arrays, Two Pointers, Sorting
    // Description:
        // You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
        // Merge nums1 and nums2 into a single array sorted in non-decreasing order.
        // The final sorted array should not be returned by the function, but instead be stored inside the array nums1. 
        // To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, 
        // and the last n elements are set to 0 and should be ignored. nums2 has a length of n
    // Examples:
        // Example 1:
            // Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
            // Output: [1,2,2,3,5,6]
            // Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
            // The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
        // Example 2:
            // Input: nums1 = [1], m = 1, nums2 = [], n = 0
            // Output: [1]
            // Explanation: The arrays we are merging are [1] and [].
            // The result of the merge is [1].
    public class LC_88_MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1; // Pointer for nums1
            int j = n - 1; // Pointer for nums2
            int k = m + n - 1; // Pointer for merged array

            // Merge in reverse order to avoid overwriting elements in nums1
            while (i >= 0 && j >= 0) {
                // Compare elements from the end of nums1 and nums2 and place the larger one at the end of nums1
                if (nums1[i] <= nums2[j]) {
                    // If the current element in nums1 is less than or equal to the current element in nums2, place the element from nums2 at the end of nums1
                    nums1[k] = nums2[j];
                    // Move the pointer for nums2 to the left
                    j--;
                } else{
                    // If the current element in nums1 is greater than the current element in nums2, place the element from nums1 at the end of nums1
                    nums1[k] = nums1[i];
                    // Move the pointer for nums1 to the left
                    i--;
                }
                // Move the pointer for the merged array to the left
                k--;
            }

            // If there are remaining elements in nums2, copy them to nums1
            while (j >= 0) {
                // Place the remaining elements from nums2 at the beginning of nums1
                nums1[k] = nums2[j];
                j--;
                k--;
            }
        }   
    }
}