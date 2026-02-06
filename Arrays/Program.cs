// See https://aka.ms/new-console-template for more information
using Arrays.Exercises;

Console.WriteLine("Choose the exercise to run:");
Console.WriteLine("1 - LC 3507: Minimum Pair Removal to Sort Array I");
Console.WriteLine("2 - LC 1: Two Sum");
Console.WriteLine("3 - LC 66: Plus One");
Console.WriteLine("4 - LC 88: Merge Sorted Array");
Console.WriteLine("5 - LC 287: Find the Duplicate Number");
Console.WriteLine("6 - LC 2351: First Letter to Appear Twice");
Console.WriteLine("7 - LC 169: Majority Element");
Console.WriteLine("8 - LC 136: Single Number");
Console.WriteLine("9 - LC 347: Top K Frequent Elements");
Console.WriteLine("10 - LC 217: Contains Duplicate");
Console.WriteLine("11 - LC 26: Remove Duplicates from Sorted Array");
Console.WriteLine("12 - LC 3379: Transformed Array");
Console.WriteLine("13 - LC 3005: Count Elements With Maximum Frequency");
Console.WriteLine("14 - LC 383: Ransom Note");
Console.WriteLine("15 - LC 283: Move Zeroes");
Console.WriteLine("16 - LC 350: Intersection of Two Arrays II");

int choice = int.Parse(Console.ReadLine() ?? "0");

while (choice < 1 || choice > 16)
{
    Console.WriteLine("Invalid choice. Please try again:");
    choice = int.Parse(Console.ReadLine() ?? "0");
}

switch (choice)
{
    case 1:
        RunLC3507();
        break;
    case 2:
        RunLC1();
        break;
    case 3:
        RunLC66();
        break;
    case 4:
        RunLC88();
        break;
    case 5:
        RunLC287();
        break;
    case 6:
        RuncLC2351();
        break;
    case 7:
        RunLC169();
        break;
    case 8:
        RunLC136();
        break;
    case 9:
        RunLC347();
        break;
    case 10:
        RunLC217();
        break;
    case 11:
        RunLC46();
        break;
    case 12:
        RunLC3379();
        break;
    case 13:
        RunLC3005();
        break;
    case 14:
        RunLC383();
        break;
    case 15:
        RunLC283();
        break;
    case 16:
        RunLC350();
        break;
    default:
        Console.WriteLine("Invalid option.");
        break;
}

// Exercise for LeetCode 3507: Minimum Pair Removal to Sort Array I
static void RunLC3507()
{
    int[] nums = [5, 2, 3, 1];
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "]");
    int result = LC_3507_MinimumPairRemovaltoSortArrayI.MinimumPairRemoval(nums);
    Console.WriteLine($"Minimum Pair Removal to Sort Array I: {result}");
}

// Exercise for LeetCode 1: Two Sum
static void RunLC1()
{
    // nums = [2,7,11,15], target = 9
    int[] nums = [2, 7, 11, 15];
    int target = 9;
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "], Target: " + target);
    int[] result = LC_1_twoSum.TwoSum(nums, target);
    Console.WriteLine($"Two Sum indices: [{result[0]}, {result[1]}]");
}

static void RunLC66()
{
    int[] digits = [1, 9, 9, 9, 9];
    Console.WriteLine("Input Digits: [" + string.Join(", ", digits) + "]");
    int[] result = LC_66_PlusOne.PlusOne(digits);
    Console.WriteLine("Result after Plus One: [" + string.Join(", ", result) + "]");
}

static void RunLC88()
{
    int[] nums1 = [1, 2, 3, 0, 0, 0];
    int m = 3;
    int[] nums2 = [2, 5, 6];
    int n = 3;
    Console.WriteLine("Input nums1: [" + string.Join(", ", nums1) + "], m: " + m);
    Console.WriteLine("Input nums2: [" + string.Join(", ", nums2) + "], n: " + n);
    LC_88_MergeSortedArray.Merge(nums1, m, nums2, n);
    Console.WriteLine("Merged nums1: [" + string.Join(", ", nums1) + "]");
}

static void RunLC287()
{
    int[] nums = [1, 3, 4, 2, 2];
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "]");
    int result = LC_287_FindTheDuplicateNumber.FindDuplicate(nums);
    Console.WriteLine($"The Duplicate Number is: {result}");
}

static void RuncLC2351()
{
    string s = "abccbaacz";
    Console.WriteLine("Input String: " + s);
    char result = LC_2351_FirstLetterToAppearTwice.RepeatedCharacter_HashSet(s);
    Console.WriteLine($"First Letter to Appear Twice: {result}");
}

static void RunLC169()
{
    int[] nums = [3, 2, 3];
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "]");
    int result = LC_169_MajorityElement.MajorityElemnt(nums);
    Console.WriteLine($"Majority Element is: {result}");
}

static void RunLC136()
{
    int[] nums = [4, 1, 2, 1, 2];
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "]");
    int result = LC_136_SingleNumber.SingleNumber(nums);
    Console.WriteLine($"Single Number is: {result}");
}

static void RunLC347()
{
    int[] nums = [1, 1, 1, 2, 2, 3];
    int k = 2;
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "], k: " + k);
    int[] resultNlogk = LC_347_TopKFrequentElements.TopKFrequentNlogk(nums, k);
    Console.WriteLine("Top K Frequent Elements (N log k): [" + string.Join(", ", resultNlogk) + "]");
    int[] resultBucketSort = LC_347_TopKFrequentElements.TopKFrequentBucketSort(nums, k);
    Console.WriteLine("Top K Frequent Elements (Bucket Sort): [" + string.Join(", ", resultBucketSort) + "]");
}

static void RunLC217()
{
    int[] nums = [1, 2, 3, 1];
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "]");
    bool result = LC_217_ContainsDuplicate.ContainsDuplicate(nums);
    Console.WriteLine($"Contains Duplicate: {result}");
}

static void RunLC46()
{
    int[] nums = [1,1,2];
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "]");
    int k = LC_26_RemoveDuplicatesfromSortedArray.RemoveDuplicates(nums);
    Console.WriteLine($"Length of array after removing duplicates: {k}");
}

static void RunLC3379()
{
    int[] nums = [3, -2, 1, 1];
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "]");
    int[] result = LC_3379_TranformedArray.ConstructTransformedArray(nums);
    Console.WriteLine("Transformed Array: [" + string.Join(", ", result) + "]");
}

static void RunLC3005()
{
    int[] nums = [1, 2, 2, 3, 1, 4];
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "]");
    int result = LC_3005_CountElementsWithMaximumFrequency.CountMaxFrequencyElements(nums);
    Console.WriteLine($"Count of Elements with Maximum Frequency: {result}");
}

static void RunLC383()
{
    string ransomNote = "a";
    string magazine = "b";
    Console.WriteLine($"Ransom Note: \"{ransomNote}\", Magazine: \"{magazine}\"");
    bool result = LC_383_RansomNote.CanConstruct(ransomNote, magazine);
    Console.WriteLine($"Can Construct Ransom Note: {result}");
}

static void RunLC283()
{
    int[] nums = [0, 1, 0, 3, 12];
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "]");
    LC_283_MoveZeros.MoveZeroes(nums);
    Console.WriteLine("Array after moving zeroes: [" + string.Join(", ", nums) + "]");
}

static void RunLC350()
{
    int[] nums1 = [1, 2, 2, 1];
    int[] nums2 = [2, 2];
    Console.WriteLine("Input nums1: [" + string.Join(", ", nums1) + "]");
    Console.WriteLine("Input nums2: [" + string.Join(", ", nums2) + "]");
    int[] result = LC_350_IntersectionOfTwoArraysII.Intersect(nums1, nums2);
    Console.WriteLine("Intersection of Two Arrays II: [" + string.Join(", ", result) + "]");
}