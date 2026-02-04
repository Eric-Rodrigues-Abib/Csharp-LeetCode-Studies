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
            int[] newNums = [];
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (Array.Exists(newNums, element => element == nums[i]))
                {
                    continue;
                }
                else
                {
                    Array.Resize(ref newNums, newNums.Length + 1);
                    newNums[newNums.Length - 1] = nums[i];
                    k++;
                }
            }
            return k;
        } 
    }
}