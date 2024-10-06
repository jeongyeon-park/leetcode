public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        for(int i = 0 ; i < nums.Length ; i++)
        {
            //ContainsKey checks whether a specific key exists in the dictionay.
            if(dictionary.ContainsKey(nums[i]))
            {
                //Compare the last index of current value and the current index.
                if(Math.Abs(dictionary[nums[i]] - i) <= k)
                    return true;
            }  
            dictionary[nums[i]] = i;
        }
        return false;
    }
}