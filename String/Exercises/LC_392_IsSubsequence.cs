namespace String.Exercises
{
    // Leetcode 392. Is Subsequence
    // Link: https://leetcode.com/problems/is-subsequence/
    // Difficulty: Easy
    // Tags: String, Two Pointers
    // description:
        // Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
        // A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) 
        // of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
    // example:
        // Input: s = "abc", t = "ahbgdc"
        // Output: true
        // Explanation: "abc" is a subsequence of "ahbgdc" because we can delete some characters of "ahbgdc" to get "abc".
    
    public class LC_392_IsSubsequence
    {
        public static bool IsSubsequence(string s, string t) {
            int i = 0;
            int j = 0;

            while (i < s.Length && j < t.Length)
            {
                if (t[j] == s[i])
                {
                    i++;
                }
                j++;
            }
            
            return i == s.Length;
        }
    }
}
