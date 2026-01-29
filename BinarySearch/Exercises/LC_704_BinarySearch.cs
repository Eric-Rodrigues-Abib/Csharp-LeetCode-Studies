namespace BinarySearch.Exercises
{
    // LeetCode 704: Binary Search
    // Link: https://leetcode.com/problems/binary-search/description/
    // Difficulty: Easy
    // Tags: Binary Search
    public class LC_704_BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            int high = nums.Length;
            int low = 0;

            while (low < high) {
                int mid = low + (high - low)/2;

                if (nums[mid] == target) {
                    return mid;
                }
                if (nums[mid] < target) {
                    low = mid+1;
                } else {
                    high = mid;
                }
            }
            return -1;
        }
    }
}