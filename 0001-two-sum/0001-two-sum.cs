public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int s = 0;
        int[] result = new int[2] {0,0};

        for(; s < nums.Length ; s++)
        {
            int sub = target - nums[s];

            if(Array.IndexOf(nums, sub, s+1) > -1) 
            {
                result[0] = s;
                result[1] = Array.IndexOf(nums,sub, s+1);
            }
        }
        return result;
    }
}