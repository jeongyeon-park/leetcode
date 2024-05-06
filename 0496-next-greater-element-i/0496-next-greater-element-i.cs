public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] results = new int[nums1.Length];
        int nums2Index = 0;
        for(int i = 0 ; i < nums1.Length ; i++)
        {   
            nums2Index = Array.IndexOf(nums2, nums1[i]);
            if(nums2Index < nums2.Length - 1)
            {
                for(int j = nums2Index + 1 ; j < nums2.Length ; j++)
                {
                    if(nums1[i] < nums2[j])
                    { 
                        results[i] = nums2[j];
                        break;
                    } 
                    results[i] = -1;
                }
            }
            else results[i] = -1;
        }
        return results;
    }
}