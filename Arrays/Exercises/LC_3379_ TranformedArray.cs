namespace Arrays.Exercises
{
    // LC 3379. Transform the Array
    // link: https://leetcode.com/problems/transformed-array/
    // Difficulty: Medium
    // Tags: Array, Simulation
    // Description:
        // You are given an integer array nums that represents a circular array. 
        // Your task is to create a new array result of the same size, following these rules:
        // For each index i (where 0 <= i < nums.length), perform the following independent actions:
            // If nums[i] > 0: Start at index i and move nums[i] steps to the right in the circular array. 
            // Set result[i] to the value of the index where you land.
            // If nums[i] < 0: Start at index i and move |nums[i]| steps to the left in the circular array. 
            // Set result[i] to the value of the index where you land.
            // If nums[i] == 0: Set result[i] to 0.
        // Return the resulting array.
    // Example:
        // Input: nums = [3, -2, 1, 1]
        // Output: [1, 1, 1, 3]
    // explanation: 
        // - i = 0: nums[0] = 3 > 0, move 3 steps to the right: 0 -> 1 -> 2 -> 3. 
        //   Set result[0] = nums[3] = 1.
        // - i = 1: nums[1] = -2 < 0, move 2 steps to the left: 1 -> 0 -> 3. 
        //   Set result[1] = nums[3] = 1.
        // - i = 2: nums[2] = 1 > 0, move 1 step to the right: 2 -> 3. 
        //   Set result[2] = nums[3] = 1.
        // - i = 3: nums[3] = 1 > 0, move 1 step to the right: 3 -> 0. 
        //   Set result[3] = nums[0] = 3.
    public class LC_3379_TranformedArray
    {
        public static int[] ConstructTransformedArray(int[] nums)
        {
            int numsLen = nums.Length;
            int[] result = new int[numsLen];
            int newIndex = 0;

            // [3, -2, 1, 1]
            // i = 0
            for (int i = 0; i < numsLen; i++)
            {
                int currentValue = nums[i];
                
                if (currentValue > 0)
                {
                    newIndex = (i + currentValue) % numsLen;
                    result[i] = nums[newIndex];
                }
                else if (currentValue < 0) 
                {
                    // calculating new index after moving |nums[i]| steps to the left
                    // why doing "(i + nums[i] % n + n) % n"?
                    // because nums[i] is negative, so we need to add n to make it positive
                    // and then take modulo n to wrap around the circular array
                    newIndex = (i + currentValue % numsLen + numsLen) % numsLen;
                    result[i] = nums[newIndex];
                } 
                else{
                    result[i] = nums[i];
                }
            }
            return result;
        }
    }
}