public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int majority = 0;
        int majorLen = nums.Length / 2;
        foreach(int num in nums)
        {
            if(map.ContainsKey(num))
            {
                map[num] = map[num] + 1;
            }
            else
            {
                map[num] = 1;
            }
        }

        foreach(int key in map.Keys)
        {
            if(map[key] > majorLen)
            {
                majority = key;
                break;
            }
        }
        return majority;
    }
}