namespace String.Exercises
{
    // LeetCode 344: Reverse String
    // Link: https://leetcode.com/problems/reverse-string/description/
    // Difficulty: Easy
    // Tags: Two Pointers, String
    // Description:
        // Write a function that reverses a string. The input string is given as an array of characters s.
        // You must do this by modifying the input array in-place with O(1) extra memory.
    // Example:
        // Input: s = ["h","e","l","l","o"]
        // Output: ["o","l","l","e","h"]

    // in-Place algorithm with O(1) extra memory -> Two Pointers approach
    public class LC_344_ReverseString
    {
        public static char[] ReverseString(char[] s) {
            int start = 0;
            int end = s.Length -1;

            while (start < end)
            {
                char temp = s[start];
                s[start]=s[end];
                s[end] = temp;

                end--;
                start++;
            }
            return s;
        }
    }
}