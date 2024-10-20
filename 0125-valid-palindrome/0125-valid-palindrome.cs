using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        string testStr = Regex.Replace(s, "[^a-zA-Z0-9]","");
        if(testStr.Length == 0) return true;
        testStr = testStr.ToLower();
        int t = testStr.Length - 1;
        for(int h = 0; h <= testStr.Length/2 ; h++)
        {
            if(testStr[h] != testStr[t]) return false; 
            t--;
        }

        return true;
    }
}