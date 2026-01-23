// See https://aka.ms/new-console-template for more information
using BinarySearch.Exercises;

Console.WriteLine("Choose the exercise to run:");
Console.WriteLine("1 - LC 04: Median of Two Sorted Arrays");

int choice = int.Parse(Console.ReadLine() ?? "0");

while (choice < 1 || choice > 1)
{
    Console.WriteLine("Invalid choice. Please try again:");
    choice = int.Parse(Console.ReadLine() ?? "0");
}

switch (choice)
{
    case 1:
        RunLC04();
        break;
    default:
        Console.WriteLine("Invalid option.");
        break;
}

static void RunLC04()
{
    int[] nums1 = [1, 3];
    int[] nums2 = [2];
    double result = LC_4_MedianofTwoSortedArrays.FindMedianSortedArrays(nums1, nums2);
    Console.WriteLine("Input Arrays: [" + string.Join(", ", nums1) + "], [" + string.Join(", ", nums2) + "]");
    Console.WriteLine($"Median of Two Sorted Arrays: {result}");
}