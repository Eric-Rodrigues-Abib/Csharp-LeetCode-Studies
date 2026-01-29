namespace String.Exercises
{
    // LeetCode Problem 28: Find the Index of the First Occurrence in a String
    // link: https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/
    // Difficulty: Easy
    // Tags: String, String Matching
    // Description:
        // Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
    // Examples:
        // Input: haystack = "sadbutsad", needle = "sad"
        // Output: 0
        // Explanation: "sad" occurs at index 0 and 6. The first occurrence is at index 0.
        // Input: haystack = "leetcode", needle = "leeto"
        // Output: -1
    public class LC_28_FindTheIndexOfTheFirstOccurenceInAString
    {
        public static int StrStr(string haystack, string needle)
        {
            if (needle.Length > haystack.Length || needle.Length == 0)
            {
                return -1;
            }

            int j = 0;
            // sadbutsad -> haystack 
            // sad -> needle
            for (int i = 0; i < haystack.Length; i++) 
            {
                if (haystack[i] == needle[j])
                {
                    j++;
                    if (j == needle.Length) 
                    {
                        return i - needle.Length + 1;
                    }
                } else {
                    i = i - j;
                    j = 0;
                }
            }
            return -1;
        }
    }
}