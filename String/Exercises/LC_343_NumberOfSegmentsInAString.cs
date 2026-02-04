namespace String.Exercises
{
    // LeetCode 343: Number of Segments in a String
    // Link: https://leetcode.com/problems/number-of-segments-in-a-string/description/
    // Difficulty: Easy
    // Tags: String
    // Description:
        // Given a string s, return the number of segments in the string.
        // A segment is defined to be a contiguous sequence of non-space characters.
    // Example:
        // Input: s = "Hello, my name is John"
        // Output: 5

    public class LC_343_NumberOfSegmentsInAString
    {
        public static int CountSegments(string s)
        {
            int count = 0;  // constant space complexity O(1)

            for (int i = 0; i < s.Length; i++) // time complexity O(n) -> loop through the string
            {
                if (s[i] != ' ' && (i == 0 || s[i - 1] == ' ')) 
                {
                    count++;
                }
            }
            return count;  // time complexity O(n) and space complexity O(1)
        }
    }
}