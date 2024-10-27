public class Solution {
    public bool CanJump(int[] nums) {
        int lastIdx = nums.Length - 1;
        int maxReach = 0;
        for(int i = 0; i <= lastIdx ; i++)
        {
            if(i > maxReach)
            {
                return false;
            }

            maxReach = Math.Max(maxReach, i + nums[i]);

            if(maxReach >= lastIdx)
            {
                return true;
            } 
        }
        return false;
    }
}