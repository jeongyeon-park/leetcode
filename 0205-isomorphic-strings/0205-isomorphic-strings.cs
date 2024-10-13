public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> maps = new Dictionary<char, char>();

        for(int i = 0; i < s.Length ; i++)
        {
            if(maps.ContainsKey(s[i]))
            {
                if(maps[s[i]] != t[i]) return false;   
            }
            else 
            {
                if(maps.ContainsValue(t[i])) return false;
                maps.Add(s[i], t[i]);
            }
        }
        return true;
    }
}