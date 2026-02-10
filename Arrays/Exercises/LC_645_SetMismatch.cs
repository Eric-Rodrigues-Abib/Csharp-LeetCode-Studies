namespace Arrays.Exercises
{
    // LeetCode 645: Set Mismatch
    // Link: https://leetcode.com/problems/set-mismatch/description/
    // Difficulty: Easy
    // Tags: Array, Hash Table, Sorting
    // Description:
        // You have a set of integers s, which originally contains all the numbers from 1 to n. Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set, which results in repetition of one number and loss of another number.
        // You are given an integer array nums representing the data status of this set after the error. Find the number that occurs twice and the number that is missing and return them in the form of an array.
    // Example 1:
        // Input: nums = [1,2,2,4]
        // Output: [2,3]
    
    public class LC_645_SetMismatch
    {
        public static int[] FindErrorNums(int[] nums) {
            int[] result = new int[2];
            HashSet<int> seen = [];
            int n = nums.Length;

            foreach(int num in nums)
            {
                if (seen.Contains(num))
                {
                    result[0] = num;
                }
                else
                {
                    seen.Add(num);
                }
            }

            for(int i = 1; i <= n; i++)
            {
                if (!seen.Contains(i))
                {
                    result[1] = i;
                    break;
                }
            }

            return result;
        }
    }   
}