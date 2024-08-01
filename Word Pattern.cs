// Given a pattern and a string s, find if s follows the same pattern.
// Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.

// Example 1:
// Input: pattern = "abba", s = "dog cat cat dog"
// Output: true

// Example 2:
// Input: pattern = "abba", s = "dog cat cat fish"
// Output: false

// Example 3:
// Input: pattern = "aaaa", s = "dog cat cat dog"
// Output: false

// Constraints:
// 1 <= pattern.length <= 300
// pattern contains only lower-case English letters.
// 1 <= s.length <= 3000
// s contains only lowercase English letters and spaces ' '.
// s does not contain any leading or trailing spaces.
// All the words in s are separated by a single space.

public class Solution {
    public bool WordPattern(string pattern, string s) {
        var words = s.Split(' ');
        if(pattern.Length != words.Length) return false;

        Dictionary<char, string> charToWord = new();
        Dictionary<string, char> wordToChar = new();

        for(int i = 0; i < pattern.Length; i++)
        {
            if (!charToWord.ContainsKey(pattern[i])) charToWord.Add(pattern[i], words[i]);
            if (!wordToChar.ContainsKey(words[i])) wordToChar.Add(words[i], pattern[i]);
            if (!charToWord[pattern[i]].Equals(words[i]) || !wordToChar[words[i]].Equals(pattern[i])) return false;
        }
        return true;
    }
}