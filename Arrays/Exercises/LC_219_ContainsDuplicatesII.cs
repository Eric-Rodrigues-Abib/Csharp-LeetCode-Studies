namespace Arrays.Exercises
{
    // LeetCode 219. Contains Duplicate II
    // https://leetcode.com/problems/contains-duplicate-ii/
    // Difficulty: Medium
    // Tags: Array, Hash Table
    // Description:
        // Given an integer array nums and an integer k, return true if there are two distinct indices 
        // i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.
    // Example:
        // Input: nums = [1,2,3,1], k = 3
        // Output: true
    
    public class LC_219_ContainsDuplicatesII
    {
        public static bool ContainsNearbyDuplicate(int[] nums, int k) {
            Dictionary<int, int> dups = [];

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dups.ContainsKey(nums[i]))
                {
                    dups.Add(nums[i], i);
                }
                else
                {
                    if(Math.Abs(dups[nums[i]] - i) <= k)
                    {
                        return true;
                    }
                    dups[nums[i]] = i;
                }
            }
            return false;
        }
    }
}