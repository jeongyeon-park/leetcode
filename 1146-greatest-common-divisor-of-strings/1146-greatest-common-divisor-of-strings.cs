public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        //길이가 더 짧은 문자열 기준으로 비교하기 
        string shortStr = str1.Length < str2.Length ? str1 : str2;
        string longStr = str1.Length >= str2.Length ? str1 : str2;
        int targetLength = shortStr.Length;
        while(targetLength > 0)
        {
            string target = shortStr.Substring(0,targetLength);
            
            if(longStr.Length % targetLength == 0 
                && shortStr.Length % targetLength == 0)
            {
                string sumLong = "";
                string sumShort = "";
                for(int i = 0; i<longStr.Length / targetLength ; i++) sumLong = sumLong + target;
                for(int j = 0; j<shortStr.Length / targetLength ; j++) sumShort = sumShort + target;
                if(longStr == sumLong && shortStr == sumShort) return target;
            }
            targetLength--;
        };
        return "";
    }
}