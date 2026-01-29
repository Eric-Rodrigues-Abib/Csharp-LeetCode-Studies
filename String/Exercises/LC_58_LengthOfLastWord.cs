namespace String.Exercises
{
    // LeetCode Problem 58: Length of Last Word
    // https://leetcode.com/problems/length-of-last-word/
    // Given a string s consisting of words and spaces, return the length of the last word in the string.
    // A word is a maximal substring consisting of non-space characters only.
    // Example:
    // Input: s = "Hello World"
    // Output: 5
    // Explanation: The last word is "World", with length 5.
    
    public class LC_58_LengthOfLastWord
    {
        public static int LengthOfLastWord(string s) {
            int last = s.Length -1;
            int result = 0;
            char lastC = ' ';

            for (int i = last; i >= 0; i--) {
                if (!(s[i] == ' '))
                {
                    result += 1;
                    lastC = s[i];
                }
                else if (lastC != ' ')
                {
                    return result;
                }
            }
            return result;
        }
    }
}