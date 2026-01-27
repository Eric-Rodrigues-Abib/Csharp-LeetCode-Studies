namespace Arrays.Exercises
{
    // LeetCode 287: Find the Duplicate Number
    // Link: https://leetcode.com/problems/find-the-duplicate-number/description/
    // Difficulty: Medium
    // Tags: Array
    // Description:
        // Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.
        // There is only one repeated number in nums, return this repeated number.
        // You must solve the problem without modifying the array nums and uses only constant extra space.
    // Example:
        // Input: nums = [1,3,4,2,2]
        // Output: 2
    public class LC_287_FindTheDuplicateNumber
    {
        public static int FindDuplicate(int[] nums)
        {
            int result = 0;
            Dictionary<int, int> keyValues = new Dictionary<int, int>();

            foreach(int num in nums)
            {
                if (keyValues.ContainsKey(num))
                {
                    result = num;
                    break;
                }
                else
                {
                    keyValues.Add(num, 1);
                }
            }
            return result;
        }
    }
}