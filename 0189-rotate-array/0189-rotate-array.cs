public class Solution {
    public void Rotate(int[] nums, int k) {
        int[] result = new int[nums.Length];
        for(int i = 0 ; i < nums.Length ; i++)
        {
            result[(i+k) % nums.Length] = nums[i];
        }
        for(int i = 0 ; i < nums.Length ; i++)
        {
            nums[i] = result[i];
        }
    }
}