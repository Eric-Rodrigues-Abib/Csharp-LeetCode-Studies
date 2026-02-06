namespace String.Exercises
{
    // Leetcode 290: Word Pattern
    // Link: https://leetcode.com/problems/word-pattern/description/
    // Difficulty: Easy
    // Tags: String, Hash Table
    // Description:
        // Given a pattern and a string s, find if s follows the same pattern.
        // Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
    // Example:
        // Input: pattern = "abba", s = "dog cat cat dog"
        // Output: true
    public class LC_290_WordPattern
    {
        public static bool WordPattern(string pattern, string s)
        {
            //pattern[i] -> s[i]
            Dictionary<char, string> charMatching1 = [];
            //s[i] -> pattern[i]
            Dictionary<string, char> charMatching2 = [];
            string[] words = s.Split(' ');

            if (words.Length != pattern.Length) return false;

            for (int i = 0; i < pattern.Length; i++)
            {
                if ((charMatching1.ContainsKey(pattern[i]) && charMatching1[pattern[i]] != words[i]) || 
                    (charMatching2.ContainsKey(words[i]) && charMatching2[words[i]] != pattern[i]))
                    {
                        return false;
                    } else {
                        charMatching1[pattern[i]] = words[i];
                        charMatching2[words[i]] = pattern[i];
                    }
            }
            return true;
        }
    } 
}