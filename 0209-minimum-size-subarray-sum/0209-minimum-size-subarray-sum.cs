public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left = 0; int right = 0; int sum = nums[0]; int result = 0;
        while(true)
        {
            //If the sum is smaller than target
            if(sum < target)
            {
                if(right < nums.Length - 1)
                {
                    right++;
                    sum+=nums[right];
                }
                else if(left < nums.Length - 1)
                {
                    sum-=nums[left];
                    left++;
                }  
            }
            else if(sum >= target)
            {
                int tmpResult = right - left + 1;//Length of current subArray.
                //If the result is 0 OR result is samller than tmpResult.
                if ( result == 0 || result > tmpResult)
                {
                    result = tmpResult;
                }

                if(left < right)
                {
                    sum -= nums[left];
                    left++;
                }
                else {
                    if ( right < nums.Length - 1 )
                    {
                        right++;
                        sum += nums[right];
                    }
                }

               
            }

            if (left == nums.Length - 1 && right == nums.Length - 1) 
            {
                int tmpResult = right - left + 1;//Length of current subArray.
                //If the result is 0 OR result is samller than tmpResult.
                if (sum >= target && ( result == 0 || result > tmpResult))
                {
                    result = tmpResult;
                }
                break;
            }
        }
        return result;
    }
}