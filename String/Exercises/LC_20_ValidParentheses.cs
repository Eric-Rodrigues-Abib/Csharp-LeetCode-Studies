namespace String.Exercises
{
    public class LC_20_ValidParentheses
    {
        // LeetCode Problem 20: Valid Parentheses
        // link: https://leetcode.com/problems/valid-parentheses/
        // Difficulty: Easy
        // Tags: Stack, String
        // Description:
            // Given a string s containing just the characters '(', ')', '{', '}', '[', and ']', determine if the input string is valid.
            // An input string is valid if:
                // Open brackets must be closed by the same type of brackets.
                // Open brackets must be closed in the correct order.
        // Examples:
            // "()"
            // "()[]{}"
            // "(]"
            // "(("
        public static bool IsValid(string s)
        {
            Stack<char> charParentheses = new();

            if (!(s.Length % 2 == 0))
            {
                return false;
            }

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[') 
                {
                    charParentheses.Push(c);
                    continue;
                }

                if (charParentheses.Count == 0)
                {
                    return false;
                } else
                {
                    char lastC = charParentheses.Pop();

                    if (c == ')' && lastC == '(' || 
                    c == '}' && lastC == '{' ||
                    c == ']' && lastC == '[')
                    {
                        continue;
                    } else
                    {
                        return false;
                    } 
                }
            } 
            return charParentheses.Count == 0;
        }
    }
}