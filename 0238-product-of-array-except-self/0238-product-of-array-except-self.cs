public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];
        int pastVal = 1;
        for(int i = 0; i<nums.Length ; i++)
        {
            answer[i] = pastVal;
            pastVal *= nums[i];
        }
        
        pastVal = 1;
        for(int j = nums.Length - 1 ; j >= 0 ; j--)
        {
            answer[j] *= pastVal;
            pastVal *= nums[j];
        }

        return answer;
    }
}