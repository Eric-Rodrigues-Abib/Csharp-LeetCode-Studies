namespace Arrays.Exercises
{
    // LeetCode 349: Intersection of Two Arrays
    // Link : https://leetcode.com/problems/intersection-of-two-arrays/description/
    // Difficulty: Easy
    // Tags: Array, Hash Table, Two Pointers, Binary Search, Sort
    // Description:
        // Given two integer arrays nums1 and nums2, return an array of their intersection.
        // Each element in the result must be unique and you may return the result in any order.
    // Example:
        // Input: nums1 = [1,2,2,1], nums2 = [2,2]
        // Output: [2]
    public class LC_349_IntersectionOfTwoArrays
    {
        public static int[] InterSection(int[] nums1, int[] nums2)
        {
            HashSet<int> intersection = [];
            HashSet<int> inter = [];

            foreach(int num in nums1)
            {
                if (!intersection.Contains(num))
                {
                    intersection.Add(num);
                }
            }

            foreach(int num in nums2)
            {
                if (intersection.Contains(num) && !inter.Contains(num))
                {
                    inter.Add(num);
                }
            }
            
            int[] result = inter.ToArray();
            return result;
        }
    }
}