public class Solution {
    public bool WordPattern(string pattern, string s) {
        List<string> keyList = s.Split(" ").ToList();
        Dictionary<char, string> maps = new Dictionary<char, string>();

        if(keyList.Count != pattern.Length) return false;
        
        for(int i = 0; i < pattern.Length; i++)
        {
            if(maps.ContainsKey(pattern[i]))
            {
                if(maps[pattern[i]] != keyList[i]) 
                    return false;
            }
            else
            {
                //Check if the current value already exists in the map.
                if(maps.ContainsValue(keyList[i]))
                    return false;
                maps.Add(pattern[i], keyList[i]);
            }
        }
        return true;
    }
}