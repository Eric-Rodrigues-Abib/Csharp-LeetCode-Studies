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

    public class LC_26_RemoveDuplicatesfromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int k = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        } 
    }
}