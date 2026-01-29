namespace String.Exercises
{
    public class LC_13_RomanToInteger
    {
        // III -> 3
        // IV -> 4
        public static int RomanToInt(string s)
        {
            Dictionary<char, int> Roman = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int count = 0;
            int previousV = 0;

            foreach (char c in s)
            {
                int currentV = Roman[c];

                if(currentV > previousV)
                {
                    count += currentV - 2 * previousV;
                }
                else
                {
                    count += currentV;
                }
                previousV = currentV;
            }

            return count;
        }
    }
}