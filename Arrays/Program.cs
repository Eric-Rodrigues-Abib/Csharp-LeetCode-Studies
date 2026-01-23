// See https://aka.ms/new-console-template for more information
using Arrays.Exercises;

Console.WriteLine("Choose the exercise to run:");
Console.WriteLine("1 - LC 3507: Minimum Pair Removal to Sort Array I");
Console.WriteLine("2 - LC 1: Two Sum");

int choice = int.Parse(Console.ReadLine() ?? "0");

while (choice < 1 || choice > 2)
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
    default:
        Console.WriteLine("Invalid option.");
        break;
}

// Exercise for LeetCode 3507: Minimum Pair Removal to Sort Array I
static void RunLC3507()
{
    int[] nums = [5, 2, 3, 1];
    int result = LC_3507_MinimumPairRemovaltoSortArrayI.MinimumPairRemoval(nums);
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "]");
    Console.WriteLine($"Minimum Pair Removal to Sort Array I: {result}");
}

// Exercise for LeetCode 1: Two Sum
static void RunLC1()
{
    // nums = [2,7,11,15], target = 9
    int[] nums = [2, 7, 11, 15];
    int target = 9;
    int[] result = LC_1_twoSum.TwoSum(nums, target);
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "], Target: " + target);
    Console.WriteLine($"Two Sum indices: [{result[0]}, {result[1]}]");
}