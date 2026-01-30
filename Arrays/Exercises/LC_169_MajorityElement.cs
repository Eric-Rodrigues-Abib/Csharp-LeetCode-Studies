namespace Arrays.Exercises
{
    // LeetCode 169: Majority Element
    // Link: https://leetcode.com/problems/majority-element/description/
    // Difficulty: Easy
    // Tags: Array, Hash Table, Divide and Conquer, Sorting
    // Description:
        // Given an array nums of size n, return the majority element.
        // The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
    // Example:
        // Input: nums = [3,2,3]
        // Output: 3    

    public class LC_169_MajorityElement
    {
        public static int MajorityElemnt(int[] nums)
        {
            // [3,2,3]
            // first we got create a new hasmap where we have the number as key
            // and we have the n times he appears as the value
            Dictionary<int, int> result = [];

            // for now, we have to iterate from the nums[] to add on our new hasmap
            foreach (int num in nums)
            {
                if(result.ContainsKey(num))
                {
                    result[num]++;
                } else 
                {
                    result.Add(num, 1);
                }
            }
            // now we have to find the number that appears more than n/2 times
            int MajorityElemnt = nums.Length / 2;
            foreach (var item in result)
            {
                if(item.Value > MajorityElemnt)
                {
                    return item.Key;
                }
            }
            return -1;
        }
    }
}