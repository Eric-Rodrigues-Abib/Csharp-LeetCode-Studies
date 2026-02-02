namespace String.Exercises
{
    // leetcode problema 3: Longest Substring Without Repeating Characters
    // link: https://leetcode.com/problems/longest-substring-without-repeating-characters/
    // Difficulty: Medium
    // Tags: Hash Table, String, Sliding Window
    // Description:
        // Given a string s, find the length of the longest substring without repeating characters.
    // Examples:
        // "abcabcbb" -> 3
        // "bbbbb" -> 1
        // "pwwkew" -> 3
    
    public class LC_3_LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            // Handle edge cases where the string length is 0 or 1
            if (s.Length == 0 || s.Length == 1)
            {
                return s.Length;
            }

            // Dictionary to store the last index of each character, why?
            // This helps us quickly find the position of a character to avoid duplicates in the current substring
            Dictionary<char, int> charIndexMap = [];
            // Two pointers to represent the current window of non-repeating characters
            int left = 0;
            int right = 0;

            // Iterate through the string using the right pointer
            for (int i = 0; i < s.Length; i++)
            {
                // Current character at the right pointer
                char currentChar = s[i];

                // If the character is already in the map, move the left pointer
                if (charIndexMap.ContainsKey(currentChar))
                {
                    // Move the left pointer to the right of the last occurrence of the current character, why "CharIndexMap[currentChar] + 1"?
                    // Because we want to exclude the previous occurrence of the current character from the substring
                    left = Math.Max(charIndexMap[currentChar] + 1, left);
                }

                // Update the last index of the current character
                charIndexMap[currentChar] = i;
                // Update the maximum length found so far, why "i - left + 1"?
                // Because "i - left + 1" gives the length of the current substring from left to right pointer
                right = Math.Max(right, i - left + 1);
            }
            // Return the maximum length of substring without repeating characters
            return right;
        }
    }
}