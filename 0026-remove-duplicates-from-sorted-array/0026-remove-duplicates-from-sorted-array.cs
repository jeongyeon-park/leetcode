public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 0;
        bool change = false;
        for (int i = 0 ; i < nums.Length ; i++)
        {
            if(k != i)
            {
                if(nums[k] == nums[i])
                {
                    change = true;
                }
                else
                {
                    if(change)
                    {
                        k++;
                        nums[k] = nums[i];  
                    }
                    else 
                    {
                        k++;   
                    }
                }
            }
        }
        return k + 1;
    }
}