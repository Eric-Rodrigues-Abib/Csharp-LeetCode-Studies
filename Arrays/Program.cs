// See https://aka.ms/new-console-template for more information
using Arrays.Exercises;

Console.WriteLine("Choose the exercise to run:");
Console.WriteLine("1 - LC 3507: Minimum Pair Removal to Sort Array I");
Console.WriteLine("2 - LC 1: Two Sum");
Console.WriteLine("3 - LC 66: Plus One");
Console.WriteLine("4 - LC 88: Merge Sorted Array");
Console.WriteLine("5 - LC 287: Find the Duplicate Number");
Console.WriteLine("6 - LC 2351: First Letter to Appear Twice");

int choice = int.Parse(Console.ReadLine() ?? "0");

while (choice < 1 || choice > 6)
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