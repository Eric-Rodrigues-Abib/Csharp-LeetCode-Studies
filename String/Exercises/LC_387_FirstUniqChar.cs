namespace String.Exercises
{
    // LeetCode 387: First Unique Character in a String
    // Link: https://leetcode.com/problems/first-unique-character-in-a-string/description
    // Difficulty: Easy
    // Tags: Hash Table, String
    // Description:
        // Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.
    // Example:
        // Input: s = "leetcode"
        // Output: 0
    
    public class LC_387_FirstUniqChar
    {
        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> repeatedChars = [];

            foreach(char c in s)
            {
                if(repeatedChars.ContainsKey(c))
                {
                    repeatedChars[c]++;
                } else {
                    repeatedChars.Add(c, 1);
                }
            }
            
            for (int i = 0; i < s.Length; i++)
            {
                if(repeatedChars[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}