using System;
using System.Collections.Generic;

public class Solution
{
    public static bool HasPalindromePermutation(string theString)
    {
        // Check if any permutation of the input is a palindrome
        var pairChars = new HashSet<char>();
        
        foreach(char c in theString) {
            if (pairChars.Contains(c)) {
                pairChars.Remove(c);
            }
            else {
                pairChars.Add(c);
            }
        }
        
        if (pairChars.Count <= 1) {
            return true;
        }
        return false;
    }
