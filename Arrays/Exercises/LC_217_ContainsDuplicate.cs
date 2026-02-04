namespace Arrays.Exercises
{
    // LeetCode 217. Contains Duplicate
    // https://leetcode.com/problems/contains-duplicate/
    // Difficulty: Medium
    // Tags: Array, Hash Table, Sorting
    // Description:
        // Given an integer array nums, return true if any value appears at least twice in the array,
        // and return false if every element is distinct.
    // Example:
        // Input: nums = [1,2,3,1]
        // Output: true

    public class LC_217_ContainsDuplicate
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> duplicates = [];

            foreach(int num in nums)
            {
                if (duplicates.ContainsKey(num))
                {
                    return true;
                }
                else
                {
                    duplicates.Add(num, 1);
                }
            }
            return false;
        }
    }
}