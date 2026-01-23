// See https://aka.ms/new-console-template for more information
using Arrays.Exercises;

Console.WriteLine("Choose the exercise to run:");
Console.WriteLine("1 - LC 3507: Minimum Pair Removal to Sort Array I");
Console.WriteLine("2 - LC 1: Two Sum");
Console.WriteLine("3 - LC 66: Plus One");

int choice = int.Parse(Console.ReadLine() ?? "0");

while (choice < 1 || choice > 3)
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