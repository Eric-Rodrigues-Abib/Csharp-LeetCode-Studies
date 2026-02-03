namespace Arrays.Exercises
{
    // LeetCode 347: Top K Frequent Elements
    // Link: https://leetcode.com/problems/top-k-frequent-elements/description/
    // Difficulty: Medium
    // Tags: Array, Hash Table, Heap (Priority Queue), Bucket Sort
    // Description:
        // Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
    // Example:
        // Input: nums = [1,1,1,2,2,3], k = 2
        // Output: [1,2]    

    public class LC_347_TopKFrequentElements
    {
        // Time Complexity: O(N log k)
        // Space Complexity: O(N)
        public static int[] TopKFrequentNlogk(int[] nums, int k)
        {
            // nums = [1,1,1,2,2,3], k = 2
            // result = [?, ?]
            int[] result = new int[k];
            Dictionary<int, int> numFrequency = [];

            // [1, 3] , [2, 2] , [3, 1];
            foreach(int num in nums)
            {
                if (numFrequency.ContainsKey(num))
                {
                    numFrequency[num]++;
                } else{
                    numFrequency.Add(num, 1);
                }
            }

            // [3,1] , [2,2] , [1,3] ascending order
            PriorityQueue<int, int> minHeap = new();
            foreach(var num in numFrequency)
            {
                minHeap.Enqueue(num.Key, num.Value);
            }

            while (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
            for (int i = 0; i < k; i++)
            {
                result[i] = minHeap.Dequeue();
            }
            return result;
        }

        // Time Complexity: O(N)
        // Space Complexity: O(N)
        public static int[] TopKFrequentBucketSort(int[] nums, int k)
        {
            // nums = [1,1,1,2,2,3], k = 2
            // result = [?, ?]
            int[] result = new int[k];
            Dictionary<int, int> numFrequency = [];

            // [1, 3] , [2, 2] , [3, 1];
            foreach(int num in nums)
            {
                if (numFrequency.ContainsKey(num))
                {
                    numFrequency[num]++;
                } else{
                    numFrequency.Add(num, 1);
                }
            }

            // Bucket Sort
            List<int>[] buckets = new List<int>[nums.Length + 1];
            foreach(var num in numFrequency)
            {
                int frequency = num.Value;
                if (buckets[frequency] == null)
                {
                    buckets[frequency] = new List<int>();
                }
                buckets[frequency].Add(num.Key);
            }

            int index = 0;
            for (int i = buckets.Length - 1; i >= 0 && index < k; i--)
            {
                if (buckets[i] != null)
                {
                    foreach (var num in buckets[i])
                    {
                        result[index] = num;
                        index++;
                        if (index == k)
                        {
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}