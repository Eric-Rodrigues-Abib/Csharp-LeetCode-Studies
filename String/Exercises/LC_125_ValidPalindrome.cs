namespace String.Exercises
{
    public class LC_125_ValidPalindrome
    {
        public static bool IsPalindrome(string s) {

            string result = RemovingNonAlphanumericaChar(s);

            int left = 0;
            int right = result.Length - 1;

            while (left < right)
            {
                if (result[left] == result[right])
                {
                    left++;
                    right--;
                } else {
                    return false;
                }
            }
            return true;
        }

        private static string RemovingNonAlphanumericaChar(string s)
        {
            string result = "";
            foreach(char c in s)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    continue;
                } else
                {
                    result += char.ToLower(c);
                }
            }
            return result;
        }
    }
}