public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        int k = 0;int i = 0;int j = 1;
        List<string> result = new List<string>();
        while( k < nums.Length)
        {
            if(j == nums.Length)
            {
                if(k == i) 
                {
                    result.Add(nums[k].ToString());
                    k++;
                }
                else 
                {
                    result.Add(nums[k].ToString() + "->" + nums[i].ToString());
                    k = i + 1;
                }
                break;
            }
           else if(nums[j] -1 != nums[i])
           {
                if(k == i) 
                {
                    result.Add(nums[k].ToString());
                    k++;
                }
                else 
                {
                    result.Add(nums[k].ToString() + "->" + nums[i].ToString());
                    k = i + 1;
                }
           }

            i++; j++;
        }
        return result;
    }
}