namespace String.Exercises
{
    // Leetcode 205: Isomorphic Strings
    // Link: https://leetcode.com/problems/isomorphic-strings/description/
    // Difficulty: Easy
    // Tags: String, Hash Table
    // Description:
        // Given two strings s and t, determine if they are isomorphic.
        // Two strings s and t are isomorphic if the characters in s can be replaced to get t.
        // All occurrences of a character must be replaced with another character while preserving the order
        // of characters. No two characters may map to the same character, but a character may map to itself.
    // Example:
        // Input: s = "egg", t = "add"
        // Output: true
    public class LC_205_IsomorphicStrings
    {
        public static bool IsIsomorphic(string s, string t)
        {
            if(s.Length != t.Length) return false;

            //s -> t
            Dictionary<char, char> charMatching1 = [];
            //t -> s
            Dictionary<char, char> charMatching2 = [];
            
            for (int i = 0; i < s.Length && i < t.Length; i++)
            {
                if ((charMatching1.ContainsKey(s[i]) && charMatching1[s[i]] != t[i]) || 
                    (charMatching2.ContainsKey(t[i]) && charMatching2[t[i]] != s[i]))
                    {
                        return false;
                    } else {
                        charMatching1[s[i]] = t[i];
                        charMatching2[t[i]] = s[i];
                    }
            }
            return true;
        }
    }
}