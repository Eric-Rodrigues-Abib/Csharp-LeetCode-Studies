namespace Arrays.Exercises
{
    // LeetCode 283: Move Zeroes
    // Link: https://leetcode.com/problems/move-zeroes/description/
    // Difficulty: Easy
    // Tags: Array, Two Pointers
    // Description:
        // Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zeroes.
        // Note that you must do this in-place without making a copy of the array.
    // Example:
        // Input: nums = [0,1,0,3,12]
        // Output: [1,3,12,0,0]
    public class LC_283_MoveZeros
    {
        public static void MoveZeroes(int[] nums)
        {
            int zeroIndex = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[zeroIndex];
                    nums[zeroIndex] = nums[i];
                    nums[i] = temp;
                    zeroIndex++;
                }
            } 
        }
    }
}