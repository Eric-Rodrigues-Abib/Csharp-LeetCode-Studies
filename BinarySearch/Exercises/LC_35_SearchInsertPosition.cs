namespace BinarySearch.Exercises
{
    // LeetCode 35: Search Insert Position
    // Link: https://leetcode.com/problems/search-insert-position/description/
    // Difficulty: Easy
    // Tags: Binary Search
    // Description: 
        //Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
        // You must write an algorithm with O(log n) runtime complexity.
    // Example 1:
        // Input: nums = [1,3,5,6], target = 5
        // Output: 2
    // Example 2:
        // Input: nums = [1,3,5,6], target = 2
        // Output: 1
    // Example 3:
        // Input: nums = [1,3,5,6], target = 7
        // Output: 4

    public class LC_35_SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int high = nums.Length;
            int low = 0;

            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] < target)
                {
                    low = mid + 1;
                } else
                {
                    high = mid;
                }
            }
            return low;
        }
    }
}