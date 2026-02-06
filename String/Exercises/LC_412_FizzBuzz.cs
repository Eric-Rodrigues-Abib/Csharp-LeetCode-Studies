namespace String.Exercises
{
    // LeetCode 412: Fizz Buzz
    // Link: https://leetcode.com/problems/fizz-buzz/
    // Difficulty: Easy
    // Tags: String
    // Description:
        // Given an integer n, return a string array answer (1-indexed) where:
        // answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
        // answer[i] == "Fizz" if i is divisible by 3.
        // answer[i] == "Buzz" if i is divisible by 5.
        // answer[i] == i (as a string) if none of the above conditions are true.
    // Examples:
        // Example 1:
            // Input: n = 3
            // Output: ["1","2","Fizz"]
            // Explanation: 1 is not divisible by 3 or 5, 2 is
            // not divisible by 3 or 5, and 3 is divisible by 3.
    
    public class LC_412_FizzBuzz
    {
        public static IList<string> FizzBuzz(int n)
        {
            List<string> result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0 && !(i % 5 == 0))
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0 && !(i % 3 == 0))
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }

            return result;
        }
    }
}