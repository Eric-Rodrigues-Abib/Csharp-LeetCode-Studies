using System.IO.Compression;

namespace Arrays.Exercises
{
    // LeetCode 500 - Keyboard Row
    // Link: https://leetcode.com/problems/keyboard-row/description/
    // Difficulty: Easy
    // Tags: Array, String
    // Description:
        // Given an array of strings words, return the words that can be typed using letters of the same row of a standard QWERTY keyboard.
    // Example 1:
        // Input: words = ["Hello","Alaska","Dad","Peace"]
        // Output: ["Alaska","Dad"]
    public class LC_500_KeyboeardRow
    {
        public static string[] FindWords(string[] words)
        {
            Dictionary<int, string> rowString = new() { {1, "qwertyuiop"}, {2, "asdfghjkl"}, {3, "zxcvbnm"} };
            List<string> result = [];

            foreach(string word in words)
            {
                int x = 0, j = 0, y = 0;
                foreach(char c in word)
                {
                    if (rowString[1].Contains(char.ToLower(c)))
                    {
                        x = 1;
                    }
                    else if (rowString[2].Contains(char.ToLower(c)))
                    {
                        j = 1;
                    }
                    else if (rowString[3].Contains(char.ToLower(c)))
                    {
                        y = 1;
                    }
                }
                if (x+j+y == 1)
                {
                    result.Add(word);
                }
            }
            return result.ToArray();
        }
    }
}