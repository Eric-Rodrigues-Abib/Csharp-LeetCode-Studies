// See https://aka.ms/new-console-template for more information
Console.WriteLine("Choose the exercise to run:");
Console.WriteLine("1 - LC 13: Roman to Integer");
Console.WriteLine("2 - LC 20: Valid Parentheses");
Console.WriteLine("3 - LC 28: Find the Index of the First Occurrence in a String");
Console.WriteLine("4 - LC 58: Length of Last Word");
Console.WriteLine("5 - LC 125: Valid Palindrome");
Console.WriteLine("6 - LC 3: Longest Substring Without Repeating Characters");

int choice = int.Parse(Console.ReadLine() ?? "0");

while (choice < 1 || choice > 6)
{
    Console.WriteLine("Invalid choice. Please try again:");
    choice = int.Parse(Console.ReadLine() ?? "0");
}

switch (choice)
{
    case 1:
        RunLC13();
        break;
    case 2:
        RunLC20();
        break;
    case 3:
        RunLC28();
        break;
    case 4:
        RunLC58();
        break;
    case 5:
        RunLC125();
        break;
    case 6:
        RunLC03();
        break;
    default:
        Console.WriteLine("Invalid option.");
        break;
}

static void RunLC13()
{
    string roman = "MCMXCIV";
    Console.WriteLine("Input Roman Numeral: " + roman);
    int result = String.Exercises.LC_13_RomanToInteger.RomanToInt(roman);
    Console.WriteLine($"Converted Integer: {result}");
}

static void RunLC20()
{
    string parentheses = "((";
    Console.WriteLine("Input Parentheses String: " + parentheses);
    bool result = String.Exercises.LC_20_ValidParentheses.IsValid(parentheses);
    Console.WriteLine($"Is Valid Parentheses: {result}");
}

static void RunLC28()
{
    string haystack = "sadbutsad";
    string needle = "sad";
    Console.WriteLine($"Input Haystack: {haystack}, Needle: {needle}");
    int result = String.Exercises.LC_28_FindTheIndexOfTheFirstOccurenceInAString.StrStr(haystack, needle);
    Console.WriteLine($"Index of First Occurrence: {result}");
}

static void RunLC58()
{
    string s = "a ";
    Console.WriteLine("Input String: " + s);
    int result = String.Exercises.LC_58_LengthOfLastWord.LengthOfLastWord(s);
    Console.WriteLine($"Length of Last Word: {result}");
}

static void RunLC125()
{
    string s = "A man, a plan, a canal: Panama";
    Console.WriteLine("Input String: " + s);
    bool result = String.Exercises.LC_125_ValidPalindrome.IsPalindrome(s);
    Console.WriteLine($"Is Palindrome: {result}");
}

static void RunLC03()
{
    string s = "abccdefghi";
    Console.WriteLine("Input String: " + s);
    int result = String.Exercises.LC_3_LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(s);
    Console.WriteLine($"Length of Longest Substring Without Repeating Characters: {result}");
}