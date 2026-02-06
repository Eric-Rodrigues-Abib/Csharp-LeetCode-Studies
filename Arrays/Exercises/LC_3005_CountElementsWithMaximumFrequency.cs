namespace Arrays.Exercises
{
    // LeetCode Problem 3005: Count Elements With Maximum Frequency


    public class LC_3005_CountElementsWithMaximumFrequency
    {
        public static int CountMaxFrequencyElements(int[] nums)
        {
            Dictionary<int, int> frequencies = [];
            int new_max = 0;

            // [1,2,2,3,1,4]
            // 1, 2  /  2, 2  /  3, 1  /  4, 1 
            foreach(int num in nums)
            {
                if (!frequencies.ContainsKey(num))
                {
                    frequencies.Add(num, 1);
                } else
                {
                    frequencies[num]++;
                }
                new_max = Math.Max(new_max, frequencies[num]);
            }

            int count = 0;
            foreach(var item in frequencies)
            {
                if (item.Value == new_max)
                {
                    count += item.Value;
                }
            }
            return count;
        }
    }
}