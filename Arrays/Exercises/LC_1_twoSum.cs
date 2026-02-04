namespace Arrays.Exercises
{
    using System;
    using System.Collections.Generic;

    // LeetCode 1: Two Sum
    // Link: https://leetcode.com/problems/two-sum/description/
    // Difficulty: Easy
    // Tags: Arrays
    // Description:
        // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        // You can return the answer in any order.
    //Example:
        // nums = [2,7,11,15], target = 9
        // Output: [0,1]
        // Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

    public class LC_1_twoSum
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            int[] answer = new int[2];
            int len = nums.Length;
            for(int i = 0; i < len; i++)
            {
                if(keyValues.ContainsKey(target - nums[i]))
                {
                    answer[0] = keyValues[target - nums[i]];
                    answer[1] = i;
                    return answer;
                }
                keyValues[nums[i]] = i;
            }

            return answer;
        }
    }
}