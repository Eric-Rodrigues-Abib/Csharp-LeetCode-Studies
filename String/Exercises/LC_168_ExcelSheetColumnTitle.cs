namespace String.Exercises
{
    // Leetcode 168: Excel Sheet Column Title
    // link: https://leetcode.com/problems/excel-sheet-column-title/
    // Description:
        // Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.
        // A -> 1
        // B -> 2
        // C -> 3
        // ...
        // Z -> 26
        // AA -> 27
        // AB -> 28
    // Example:
        // Input: columnNumber = 28
        // Output: "AB"
    public class LC_168_ExcelSheetColumnTitle
    {
        public static string ConvertToTitle(int columnNumber)
        {
            string result = "";

            while (columnNumber > 0) // time complexity O(log n)
            {
                columnNumber--;
                int remainder = columnNumber % 26;
                char currentChar = (char)(remainder + 'A');
                result = currentChar + result;
                columnNumber /= 26;
            }

            return result;
        }
    }
}