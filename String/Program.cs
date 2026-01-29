// See https://aka.ms/new-console-template for more information
Console.WriteLine("Choose the exercise to run:");
Console.WriteLine("1 - LC 13: Roman to Integer");

int choice = int.Parse(Console.ReadLine() ?? "0");

while (choice < 1 || choice > 1)
{
    Console.WriteLine("Invalid choice. Please try again:");
    choice = int.Parse(Console.ReadLine() ?? "0");
}

switch (choice)
{
    case 1:
        RunLC13();
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