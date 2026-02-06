// See https://aka.ms/new-console-template for more information
Console.WriteLine("Choose the exercise to run:");
Console.WriteLine("1 - LC 13: Roman to Integer");
Console.WriteLine("2 - LC 20: Valid Parentheses");
Console.WriteLine("3 - LC 28: Find the Index of the First Occurrence in a String");
Console.WriteLine("4 - LC 58: Length of Last Word");
Console.WriteLine("5 - LC 125: Valid Palindrome");
Console.WriteLine("6 - LC 3: Longest Substring Without Repeating Characters");
Console.WriteLine("7 - LC 387: First Unique Character in a String");
Console.WriteLine("8 - LC 344: Reverse String");
Console.WriteLine("9 - LC 343: Number of Segments in a String");
Console.WriteLine("10 - LC 168: Excel Sheet Column Title");
Console.WriteLine("11 - LC 392: Is Subsequence");
Console.WriteLine("12 - LC 205: Isomorphic Strings");
Console.WriteLine("13 - LC 290: Word Pattern");
Console.WriteLine("14 - LC 345: Reverse Vowels of a String");
Console.WriteLine("15 - LC 389: Find the Difference");
Console.WriteLine("16 - LC 412: Fizz Buzz");

int choice = int.Parse(Console.ReadLine() ?? "0");

while (choice < 1 || choice > 16)
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
    case 7:
        RunLC387();
        break;
    case 8:
        RunLC344();
        break;
    case 9:
        RunLC343();
        break;
    case 10:
        RunLC168();
        break;
    case 11:
        RunLC392();
        break;
    case 12:
        RunLC205();
        break;
    case 13:
        RunLC290();
        break;
    case 14:
        RunLC345();
        break;
    case 15:
        RunLC389();
        break;
    case 16:
        RunLC412();
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

static void RunLC387()
{
    string s = "leetcode";
    Console.WriteLine("Input String: " + s);
    int result = String.Exercises.LC_387_FirstUniqChar.FirstUniqChar(s);
    Console.WriteLine($"Index of First Unique Character: {result}");
}

static void RunLC344()
{
    char[] s = new char[] {'h','e','l','l','o'};
    Console.WriteLine("Input String Array: " + new string(s));
    char[] result = String.Exercises.LC_344_ReverseString.ReverseString(s);
    Console.WriteLine($"Reversed String Array: " + new string(result));
}

static void RunLC343()
{
    string s = "Hello, my name is John";
    Console.WriteLine("Input String: " + s);
    int result = String.Exercises.LC_343_NumberOfSegmentsInAString.CountSegments(s);
    Console.WriteLine($"Number of Segments in String: {result}");
}

static void RunLC168()
{
    int columnNumber = 28;
    Console.WriteLine("Input Column Number: " + columnNumber);
    string result = String.Exercises.LC_168_ExcelSheetColumnTitle.ConvertToTitle(columnNumber);
    Console.WriteLine($"Excel Sheet Column Title: {result}");
}

static void RunLC392()
{
    string s = "abc";
    string t = "ahbgdc";
    Console.WriteLine($"Input String s: {s}, t: {t}");
    bool result = String.Exercises.LC_392_IsSubsequence.IsSubsequence(s, t);
    Console.WriteLine($"Is Subsequence: {result}");
}

static void RunLC205()
{
    string s = "egg";
    string t = "add";
    Console.WriteLine($"Input String s: {s}, t: {t}");
    bool result = String.Exercises.LC_205_IsomorphicStrings.IsIsomorphic(s, t);
    Console.WriteLine($"Are Isomorphic: {result}");
}

static void RunLC290()
{
    string pattern = "abba";
    string s = "dog cat cat dog";
    Console.WriteLine($"Input Pattern: {pattern}, String: {s}");
    bool result = String.Exercises.LC_290_WordPattern.WordPattern(pattern, s);
    Console.WriteLine($"Does String Follow Pattern: {result}");
}

static void RunLC345()
{
    string s = "hello";
    Console.WriteLine("Input String: " + s);
    string result = String.Exercises.LC_345_ReverseVowelsOfAString.ReverseVowels(s);
    Console.WriteLine($"String after Reversing Vowels: {result}");
}

static void RunLC389()
{
    string s = "abcd";
    string t = "abcde";
    Console.WriteLine($"Input String s: {s}, t: {t}");
    char result = String.Exercises.LC_389_FindTheDifference.FindTheDifference(s, t);
    Console.WriteLine($"The Difference Character: {result}");
}

static void RunLC412()
{
    int n = 15;
    Console.WriteLine("Input Number: " + n);
    IList<string> result = String.Exercises.LC_412_FizzBuzz.FizzBuzz(n);
    Console.WriteLine("FizzBuzz Result: [" + string.Join(", ", result) + "]");
}
