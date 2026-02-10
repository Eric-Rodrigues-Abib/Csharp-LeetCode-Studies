namespace Arrays.Exercises
{
    // LeetCode 449: Find All Disappeared in an Array
    // Link: https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
    // Difficulty: Easy
    // Tags: Array, Hash Table
    // Description:
        // Given an array nums of n integers where nums[i] is in the range [1
        // , n], return an array of all the integers in the range [1, n] that do not appear in nums.
    // Example 1:
        // Input: nums = [4,3,2,7,8,2,3,1]
        // Output: [5,6]
    
    public class LC_448_FindAllDIsappearedInAArray
    {
        public static List<int> FindDisappearedNumbers(int[] nums) {
            List<int> result = [];
            HashSet<int> seen = [];
            int n = nums.Length;

            // 1,2,3,4,7,8
            foreach(int num in nums)
            {
                if (!seen.Contains(num))
                {
                    seen.Add(num);
                }
            }

            for(int i = 0; i < n; i++)
            {
                if (!seen.Contains(i+1))
                {
                    result.Add(i+1);
                }
            }

            return result;
        }
    }
}