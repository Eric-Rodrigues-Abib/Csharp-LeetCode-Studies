namespace Arrays.Exercises
{
    // LeetCode 2351: First Letter to Appear Twice
    // Link : https://leetcode.com/problems/first-letter-to-appear-twice/description/
    // Difficulty: Easy
    // Tags: Array, Hash Table
    // Description:
        // Given a string s consisting of lowercase English letters, return the first letter to appear twice.
        // Note: A letter a appears twice before another letter b if the second occurrence of a is before the second occurrence of b.
    // Example:
        // Input: s = "abccbaacz"
        // Output: "c"
    public class LC_2351_FirstLetterToAppearTwice
    {
        public static char RepeatedCharacter(string s)
        {
            char[] seen = [];
            char result = ' ';
            foreach (char c in s)
            {
                if (Array.Exists(seen, element => element == c))
                {
                    result = c;
                    return result;
                }
                else
                {
                    Array.Resize(ref seen, seen.Length + 1);
                    seen[seen.Length - 1] = c;
                }
            }
            return result;
        }

        public static char RepeatedCharacter_HashSet(string s)
        {
            HashSet<char> seen = [];
            foreach (char c in s)
            {
                if (seen.Contains(c))
                {
                    return c;
                }
                else
                {
                    seen.Add(c);
                }
            }
            return ' ';
        }
    }
}