namespace Arrays.Exercises
{
    // LeetCode 496. Next Greater Element I
    // https://leetcode.com/problems/next-greater-element-i/
    // Difficulty: Easy
    // Tags: Array, Hash Table, Stack
    // Description:
        // The next greater element of some element x in an array is the first greater element that
        // is to the right of x in the same array. You are given two distinct 0-indexed integer arrays
        // nums1 and nums2, where nums1 is a subset of nums2.
        // For each 0 <= i < nums1.length, find the index j such that nums1[i] == nums2[j] and determine the next greater element of nums2[j]
        // in nums2. If there is no next greater element, then the answer for this query is -1. Return an array ans of length nums1.length 
        // such that ans[i] is the next greater element as described above.
    // Example:
        // Input: nums1 = [4,1,2], nums2 = [1,3,4,2]
        // Output: [-1,3,-1]
    public class LC_496_NextGreaterElementI
    {
        public static int[] NextGreaterElement(int[] nums1, int[] nums2) {
            // Creating the result for adding the values
            int[] result = new int[nums1.Length];
            int index = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                index = Array.IndexOf(nums2, nums1[i]);
                if (index == nums2.Length -1)
                {
                    result[i] = -1;
                }

                for (int j = index+1; j < nums2.Length; j++)
                {
                    if (nums2[j] > nums1[i])
                    {
                        result[i] = nums2[j];
                        break;
                    }
                    result[i] = -1;
                }
            }
            return result;
        }
    }
}