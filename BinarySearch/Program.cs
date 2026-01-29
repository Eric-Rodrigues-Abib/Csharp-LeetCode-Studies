// See https://aka.ms/new-console-template for more information
using BinarySearch.Exercises;

Console.WriteLine("Choose the exercise to run:");
Console.WriteLine("1 - LC 04: Median of Two Sorted Arrays");
Console.WriteLine("2 - LC 35: Search Insert Position");
Console.WriteLine("3 - LC 34: Find First and Last Position of Element in Sorted Array");
Console.WriteLine("4 - Entrevista BTG: Check Anagrams");
int choice = int.Parse(Console.ReadLine() ?? "0");

while (choice < 1 || choice > 4)
{
    Console.WriteLine("Invalid choice. Please try again:");
    choice = int.Parse(Console.ReadLine() ?? "0");
}

switch (choice)
{
    case 1:
        RunLC04();
        break;
    case 2:
        RunLC35();
        break;
    case 3:
        RunLC34();
        break;
    case 4:
        RunEntrevistaBTG();
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

static void RunLC35()
{
    int[] nums = [1, 3, 5, 6];
    int target = 5;
    int result = LC_35_SearchInsertPosition.SearchInsert(nums, target);
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "], Target: " + target);
    Console.WriteLine($"Search Insert Position: {result}");
}

static void RunLC34()
{
    int[] nums = [5, 7, 7, 8, 8, 10];
    int target = 8;
    Console.WriteLine("Input Array: [" + string.Join(", ", nums) + "], Target: " + target);
    int[] result = LC_34_FindFirstandLastPositionOfElementInSortedArray.SearchRange(nums, target);
    Console.WriteLine($"First and Last Position of Element in Sorted Array: [" + string.Join(", ", result) + "]");
}

static void RunEntrevistaBTG()
{
    string str1 = "aab";
    string str2 = "aba";
    bool result = EntrevistaBTG.IsAnagramOrNot(str1, str2);
    Console.WriteLine($"Are \"{str1}\" and \"{str2}\" anagrams? {result}");
}