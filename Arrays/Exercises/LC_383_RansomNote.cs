namespace Arrays.Exercises
{
    // LeetCode Problem 3005: Count Elements With Maximum Frequency
    // link: https://leetcode.com/problems/count-elements-with-maximum-frequency/
    // Difficulty: Easy
    // Tags: Arrays, Hash Table
    // Description:
        // Given two strings ransomNote and magazine, return true if ransomNote can be 
        // constructed by using the letters from magazine and false otherwise.
        // Each letter in magazine can only be used once in ransomNote.
    // Example:
        // Input: ransomNote = "a", magazine = "b"
        // Output: false

    public class LC_383_RansomNote
    {
        public static bool CanConstruct(string ransomNote, string magazine) {
            Dictionary<char, int> canC = [];

            foreach(char c in magazine)
            {
                if(canC.ContainsKey(c))
                {
                    canC[c]++;
                }
                else{
                    canC.Add(c, 1);
                }
            }

            foreach(char c in ransomNote) 
            {
                if(!canC.ContainsKey(c))
                {
                    return false;
                } 
                
                canC[c]--;
                
                if (canC[c] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}