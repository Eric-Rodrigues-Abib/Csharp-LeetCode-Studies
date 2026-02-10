namespace Arrays.Exercises
{
    // LeetCode 66: Plus One
    // Link: https://leetcode.com/problems/plus-one/description/
    // Difficulty: Easy
    // Tags: Array
    // Description:
        //You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. 
        // The digits are ordered from most significant to least significant in left-to-right order. 
        // The large integer does not contain any leading 0's.
        // Increment the large integer by one and return the resulting array of digits.
    // Example 1:
        // Input: digits = [1,2,3]
        // Output: [1,2,4]
        // Explanation: The array represents the integer 123.
        // Incrementing by one gives 123 + 1 = 124.
        // Thus, the result should be [1,2,4].
    // Example 2:
        // Input: digits = [4,3,2,1]
        // Output: [4,3,2,2]
        // Explanation: The array represents the integer 4321.
        // Incrementing by one gives 4321 + 1 = 4322.
        // Thus, the result should be [4,3,2,2].
    // Example 3:
        // Input: digits = [9]
        // Output: [1,0]
        // Explanation: The array represents the integer 9.
        // Incrementing by one gives 9 + 1 = 10.
        // Thus, the result should be [1,0].

    public class LC_66_PlusOne
    {
        public static int[] PlusOne(int[] digits)
        {
            // Initialize carry to 1 since we are adding one to the number
            int carry = 1;
            // Traverse the digits array from the last digit to the first
            for (int i = digits.Length - 1; i >= 0; i--) {
                // Calculate the sum of the current digit and the carry
                int sum = digits[i] + carry;
                // Update the current digit to be the last digit of the sum
                // why? because if the sum is 10 or greater, we only want to keep the last digit in the current position and carry over the rest to the next iteration
                digits[i] = sum % 10;
                // Update the carry for the next iteration
                carry = sum / 10;
            }

            // If there is still a carry after processing all digits, we need to create a new array
            if (carry == 1) {
                // Create a new array with an additional digit at the front
                int[] result = new int[digits.Length + 1];
                // Set the first digit to 1 (the carry)
                result[0] = 1;
                // Copy the original digits to the new array starting from index 1
                for (int i = 0; i < digits.Length; i++)
                {
                    result[i + 1] = digits[i];
                }
                // Return the new array with the carry included
                return result;
            }
            return digits;
        }
    }
}