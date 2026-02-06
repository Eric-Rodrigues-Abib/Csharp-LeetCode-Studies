namespace String.Exercises
{
    // LeetCode 345: Reverse Vowels of a String
    // Link: https://leetcode.com/problems/reverse-vowels-of-a-string/description/
    // Difficulty: Easy
    // Tags: String, Two Pointers
    // Description:
        // Given a string s, reverse only all the vowels in the string and return it.
        // The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.
    // Example:
        // Input: s = "hello"
        // Output: "holle"
    public class LC_345_ReverseVowelsOfAString
    {
        public static string ReverseVowels(string s)
        {
            int start = 0;
            char[] word = s.ToCharArray();
            int end = word.Length - 1;

            while (start < end)
            {
                if (!IsVowels(word[start]) && start < end)
                {
                    start++;
                }
                if (!IsVowels(word[end]) && end > start)
                {
                    end--;
                }
                if (IsVowels(word[start]) && IsVowels(word[end]))
                {
                    char temp = word[start];
                    word[start] = word[end];
                    word[end] = temp;

                    end--;
                    start++;
                }
            }
            return new string(word);
        }

        private static bool IsVowels(char c)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'];
            if (Array.Exists(vowels, element => element == c))
            {
                return true;
            } 
            return false;
        }
    }
}