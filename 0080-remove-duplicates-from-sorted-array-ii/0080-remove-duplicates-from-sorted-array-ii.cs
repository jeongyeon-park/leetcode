public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int j = 1; //for write
        int cnt = 1; //for count
        for(int i = 1 ; i < nums.Length ; i++)//for write
        {
            if(nums[i] == nums[i-1])
            {
                cnt++;
            }
            else 
            {
                cnt = 1;
            }

            if(cnt <= 2) 
            {
                nums[j] = nums[i];
                j++;
            }
        }
        return j;
    }
}