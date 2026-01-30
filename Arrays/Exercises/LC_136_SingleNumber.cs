namespace Arrays.Exercises
{
    // LeetCode 136: Single Number
    // Link: https://leetcode.com/problems/single-number/description/
    // Difficulty: Easy
    // Tags: Array, Bit Manipulation, Hash Table
    // Description:
        // Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.
        // You must implement a solution with a linear runtime complexity and use only constant extra space.
    // Example:
        // Input: nums = [4,1,2,1,2]
        // Output: 4    

    public class LC_136_SingleNumber
    {
        public static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> numbers = [];

            foreach (int num in nums)
            {
                if (numbers.ContainsKey(num))
                {
                    numbers.Remove(num);
                } 
                else 
                {
                    numbers.Add(num, 1);
                }
            }

            foreach (var key in numbers)
            {
                return key.Key;
            }
            return 0;
        }

        public static int SingleNumberWithXOR(int[] nums)
        {
            int result = 0;

            foreach (int num in nums)
            {
                result = result ^ num;
            }

            return result;
        }
    }
}