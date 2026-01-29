namespace BinarySearch.Exercises
{
    public class EntrevistaBTG
    {
        // aab
        // aba        
        public static bool IsAnagramOrNot(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            Dictionary<char, int> charCount = [];

            // aab
            foreach(char c in str1)
            {
                if(charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            foreach(char c in str2)
            {
                if(!charCount.ContainsKey(c))
                {
                    return false;
                }

                charCount[c]--;

                if(charCount[c] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}