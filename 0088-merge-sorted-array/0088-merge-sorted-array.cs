public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int j = n-1;//for nums2 
        int k = m-1;//for nums1
        int i = nums1.Length - 1;
        while(j >= 0)
        {
            if(k >= 0 && nums1[k] > nums2[j])
            {
                nums1[i] = nums1[k];
                k--;
            }
            else
            {
                nums1[i] = nums2[j];
                j--;
            }
            i--;
        }
    }
}