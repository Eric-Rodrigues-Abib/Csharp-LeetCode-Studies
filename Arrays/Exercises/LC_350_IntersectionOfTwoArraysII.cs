namespace Arrays.Exercises
{
    // LeetCode 350: Intersection of Two Arrays II
    // Link : https://leetcode.com/problems/intersection-of-two-arrays-ii/description/
    // Difficulty: Easy
    // Tags: Array, Hash Table, Two Pointers, Sorting
    // Description:
        // Given two integer arrays nums1 and nums2, return an array of their intersection.
        // Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.
    // Example:
        // Input: nums1 = [1,2,2,1], nums2 = [2,2]
        // Output: [2,2]
    public class LC_350_IntersectionOfTwoArraysII
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> intersection = [];
            int[] result = [];

            foreach(int num in nums1)
            {
                if (!intersection.ContainsKey(num))
                {
                    intersection.Add(num, 1);
                }
                else
                {
                    intersection[num]++;
                }
            }

            foreach(int num in nums2)
            {
                if (intersection.ContainsKey(num) && intersection[num] > 0)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = num;
                    intersection[num]--;
                }
            }
            return result;
        }
    }
}