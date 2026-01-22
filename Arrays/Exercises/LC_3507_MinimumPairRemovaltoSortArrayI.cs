namespace Arrays.Exercises
{
    using System;
    using System.Collections.Generic;

    // LeetCode 3507: Minimum Pair Removal to Sort Array I
    // Link: https://leetcode.com/problems/minimum-pair-removal-to-sort-array-i/?envType=daily-question&envId=2026-01-22
    // Difficulty: Easy
    // Tags: Arrays
    public class LC_3507_MinimumPairRemovaltoSortArrayI
    {
        public static int MinimumPairRemoval(int[] nums) {
            List<int> arr = [.. nums];

            int operations = 0;
            while (!IsNonDecreasing(arr)) {
                int min = int.MaxValue;
                int size = arr.Count;
                int currentValue = 0;
                int index = 0;

                for (int i = 0; i < size - 1; i++) {
                    currentValue = arr[i] + arr[i + 1];
                    if (currentValue < min) {
                        min = currentValue;
                        index = i;
                    }
                }

                arr[index] = min;
                arr.RemoveAt(index + 1);
                operations++;
            }
            return operations;
        }

        private static bool IsNonDecreasing(List<int> list) {
            for (int i = 1; i < list.Count; i++) {
                if (list[i] < list[i - 1]) return false;
            }
            return true;
        }
    }
}