namespace BinarySearch.Exercises
{

    // LeetCode 34: Find First and Last Position of Element in Sorted Array
    // Link: https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/description/
    // Difficulty: Medium
    // Tags: Binary Search
    // Description:
        // Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.
        // If target is not found in the array, return [-1, -1].
        // You must write an algorithm with O(log n) runtime complexity.
    // Example 1:
        // Input: nums = [5,7,7,8,8,10], target = 8
        // Output: [3,4]
    // Example 2:
        // Input: nums = [5,7,7,8,8,10], target = 6
        // Output: [-1,-1]
    // Example 3:
        // Input: nums = [], target = 0
        // Output: [-1,-1]

    public class LC_34_FindFirstandLastPositionOfElementInSortedArray
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            int firstOcurrence = FindFirstOcurrence(nums, target);
            int lastOcurrence = FindLastOcurrence(nums, target);
            return [firstOcurrence, lastOcurrence];
        }

        private static int FindFirstOcurrence(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length;
            int firstOcurrence = -1;

            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    firstOcurrence = mid;
                    high = mid - 1;
                } else if (nums[mid] < target)
                {
                    low = mid + 1;
                } else
                {
                    high = mid - 1;
                }
            }
            return firstOcurrence;
        }
        
        private static int FindLastOcurrence(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length;
            int lastOcurrence = -1;

            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] == target)
                {
                    lastOcurrence = mid;
                    low = mid + 1;
                } else if (nums[mid] < target)
                {
                    low = mid + 1;
                } else
                {
                    high = mid - 1;
                }
            }
            return lastOcurrence;
        }
    }
}